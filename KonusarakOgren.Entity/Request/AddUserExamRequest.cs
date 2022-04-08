using KonusarakOgren.Entity.SqlLiteKonusarakOgren.Entities.Exam;
using KonusarakOgren.Entity.SqlLiteKonusarakOgren.Entities.Question;

namespace KonusarakOgren.Entity.Request
{
    public class AddUserExamRequest
    {
        public Exam Exam{ get; set; }
        public List<Question> Questions { get; set; }
    }
}
