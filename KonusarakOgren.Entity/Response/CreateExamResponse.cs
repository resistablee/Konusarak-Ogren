using KonusarakOgren.Entity.SqlLiteKonusarakOgren.Entities.Question;

namespace KonusarakOgren.Entity.Response
{
    public class CreateExamResponse
    {
        public int ArticleID { get; set; }
        public string ArticleTitle { get; set; }
        public string Article { get; set; }

        public List<OneQuestion> Questions { get; set; }
    }

    public class OneQuestion
    {
        public Question Question { get; set; }
        public IList<Answer> Answers { get; set; }
    }
}
