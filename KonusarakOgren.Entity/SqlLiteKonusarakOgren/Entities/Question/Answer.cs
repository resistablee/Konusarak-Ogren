
namespace KonusarakOgren.Entity.SqlLiteKonusarakOgren.Entities.Question
{
    public class Answer : Entity
    {
        public int QuestionID { get; set; }

        public string Text { get; set; }
        public bool? IsTrue { get; set; }

        public virtual Question? Question { get; set; }
    }
}
