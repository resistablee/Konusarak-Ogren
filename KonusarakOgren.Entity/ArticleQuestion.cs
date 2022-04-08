using KonusarakOgren.Entity.SqlLiteKonusarakOgren.Entities.Question;

namespace KonusarakOgren.Entity
{
    public class ArticleQuestion
    {
        public Question Question { get; set; }
        public List<Answer> Answers{ get; set; }
        public int CorrectAnswerID { get; set; }
    }
}
