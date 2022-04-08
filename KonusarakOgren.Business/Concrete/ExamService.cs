using KonusarakOgren.Business.Abstract;
using KonusarakOgren.DataAccess.Concrete;
using KonusarakOgren.DataAccess.Context;
using KonusarakOgren.Entity.Response;
using KonusarakOgren.Entity.Result;
using KonusarakOgren.Entity.SqlLiteKonusarakOgren.Entities.Article;
using KonusarakOgren.Entity.SqlLiteKonusarakOgren.Entities.Exam;
using KonusarakOgren.Entity.SqlLiteKonusarakOgren.Entities.Question;
using KonusarakOgren.Entity.SqlLiteKonusarakOgren.Entities.User;
using Microsoft.EntityFrameworkCore;

namespace KonusarakOgren.Business.Concrete
{
    public class ExamService : GenericRepository<Exam>, IExamService
    {
        private readonly KonusarakOgrenContext _context;

        public ExamService(KonusarakOgrenContext context) : base(context)
        {
            _context = context;
        }


        public async Task<ServiceResult<CreateExamResponse>> CreateExam()
        {
            Random random = new Random();

            List<Article> articleList = await _context.Set<Article>().AsNoTracking().Where(x => x.IsDeleted == false).ToListAsync();

            int randomValueForArticle = random.Next(articleList.Count);

            Article article = articleList[randomValueForArticle];

            var articleQuestionList = await _context.Set<Question>().AsNoTracking().Where(x=>x.ArticleID == article.Id).ToListAsync();

            List<OneQuestion> questions = new List<OneQuestion>();
            Question question;

            int randomValue = 0;

            //Makale sorularını CreateExamResponse'a eklemek için veri tabanından çektiğimiz bölüm
            for (int i = 0; i < 4; i++)
            {
                randomValue = random.Next(articleQuestionList.Count);
                question = articleQuestionList[randomValue];

                //Burada iki veya daha fazla defa aynı soru eklenmemesi için
                //sürekli articleQuestionList[randomValue] elemanı Questions
                //listesinde var mı diye bakıyoruz. Eğer varsa while içinde
                //kalacağından sürekli yeni bir random değer üretip, o üretilen
                //indexteki elemanın Questions listesinde varlığını kontrol edecek.
                //Questions listesinde articleQuestionList[randomValue] elemanı yoksa
                //whilde'dan çıkıp elemanı Questions listesine ekleyecek.
                while (questions.Any(x => x.Question == question))
                {
                    randomValue = random.Next(articleQuestionList.Count);
                    question = articleQuestionList[randomValue];
                }


                var questionAnswers = await _context.Set<Answer>().AsNoTracking().Where(x => x.QuestionID == question.Id).ToListAsync();

                questions.Add(new OneQuestion
                {
                    Question = question,
                    Answers = questionAnswers
                });
            }

            return new ServiceResult<CreateExamResponse>
            {
                Status = ResultStatus.Successful,
                Message = "Exam is created",
                Data = new CreateExamResponse
                {
                    ArticleID = article.Id,
                    Article = article.Text,
                    ArticleTitle = article.Title,
                    Questions = questions
                }
            };
        }

        public async Task<ServiceResult<List<UserExamResponse>>> UserExam(int userId)
        {
            var exams = await FindAllAsync(x => x.UserID == userId && !x.IsDeleted);

            Article article;
            User user;
            List<UserExamResponse> response = new List<UserExamResponse>();
            foreach (var exam in exams)
            {
                article = await _context.Set<Article>().AsNoTracking().FirstOrDefaultAsync(x => x.Id == exam.ArticleID);

                response.Add(new UserExamResponse
                {
                    Id = exam.Id,
                    ArticleID = exam.ArticleID,
                    ExamDate = exam.ExamDate,
                    ArticleTitle = article.Title,
                    UserID = userId,
                });
            }

            return new ServiceResult<List<UserExamResponse>>
            {
                Data = response,
                Message = "Successful",
                Status = ResultStatus.Successful
            };
        }
    }
}
