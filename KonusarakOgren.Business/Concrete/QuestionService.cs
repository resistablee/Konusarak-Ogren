using KonusarakOgren.Business.Abstract;
using KonusarakOgren.DataAccess.Concrete;
using KonusarakOgren.DataAccess.Context;
using KonusarakOgren.Entity;
using KonusarakOgren.Entity.Request;
using KonusarakOgren.Entity.Result;
using KonusarakOgren.Entity.SqlLiteKonusarakOgren.Entities.Question;

namespace KonusarakOgren.Business.Concrete
{
    public class QuestionService : GenericRepository<Question>, IQuestionService
    {
        private readonly KonusarakOgrenContext _context;
        private readonly IAnswerService _answerService;

        public QuestionService(KonusarakOgrenContext context,
                            IAnswerService answerService) : base(context)
        {
            _context = context;
            _answerService = answerService;
        }

        public async Task<ServiceResult<List<ArticleQuestion>>> CreateAsync(CreateQuestionRequest request)
        {
            int questionId = 0;

            foreach (var question in request.ArticleQuestion)
            {
                question.Question.CreatedOn = DateTime.Now;
                question.Question.ArticleID = request.ArticleID;
                questionId = (await InsertAsync(question.Question)).Id;

                foreach (var answer in question.Answers)
                {
                    if (answer == question.Answers[question.CorrectAnswerID])
                        answer.IsTrue = true;
                    else
                        answer.IsTrue = false;

                    answer.CreatedOn = DateTime.Now;
                    answer.QuestionID = questionId;
                    await _answerService.InsertAsync(answer);
                }
            }

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (Exception ex)
            {
                return new ServiceResult<List<ArticleQuestion>>
                {
                    Status = ResultStatus.ErrorOccurred,
                    Message = ex.Message
                };
            }

            return new ServiceResult<List<ArticleQuestion>>
            {
                Status = ResultStatus.Successful,
                Message = "Question added.",
                Data = request.ArticleQuestion
            };
        }
    }
}
