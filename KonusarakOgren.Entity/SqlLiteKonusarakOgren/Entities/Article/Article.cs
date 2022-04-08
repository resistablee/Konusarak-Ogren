
namespace KonusarakOgren.Entity.SqlLiteKonusarakOgren.Entities.Article
{
    public class Article : Entity
    {
        public string URL { get; set; }
        public string Title { get; set; }
        public string Text { get; set; }

        public virtual ICollection<Question.Question> Questions{ get; set; }
        public virtual ICollection<Exam.Exam> Exams{ get; set; }
    }
}
