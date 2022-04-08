
namespace KonusarakOgren.Entity.SqlLiteKonusarakOgren.Entities.Question
{
    public class Question : Entity
    {
        public int ArticleID { get; set; }
        public string Text { get; set; }

        public virtual Article.Article? Article { get; set; }

        public virtual ICollection<Answer>? Answers { get; set; }
    }
}
