
namespace KonusarakOgren.Entity.Response
{
    public class UserExamResponse
    {
        public int Id { get; set; }
        public int ArticleID { get; set; }
        public int UserID { get; set; }
        public DateTime ExamDate { get; set; }
        public string ArticleTitle { get; set; }
    }
}
