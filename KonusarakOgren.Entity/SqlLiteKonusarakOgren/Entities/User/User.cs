
namespace KonusarakOgren.Entity.SqlLiteKonusarakOgren.Entities.User
{
    public class User : Entity
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public bool IsActive { get; set; }
        public UserType Type { get; set; }


        public virtual ICollection<Exam.Exam> Exams { get; set; }
    }
}
