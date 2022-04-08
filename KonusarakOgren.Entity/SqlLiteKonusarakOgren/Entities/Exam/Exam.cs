
namespace KonusarakOgren.Entity.SqlLiteKonusarakOgren.Entities.Exam
{
    public class Exam : Entity
    {
        public int UserID { get; set; }
        public int ArticleID { get; set; }
        public DateTime ExamDate { get; set; }

        public virtual User.User? User { get; set; }
        public virtual Article.Article? Article { get; set; }
    }
}
