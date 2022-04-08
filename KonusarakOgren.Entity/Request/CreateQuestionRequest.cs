
namespace KonusarakOgren.Entity.Request
{
    public class CreateQuestionRequest
    {
        public int ArticleID { get; set; }
        public List<ArticleQuestion> ArticleQuestion { get; set; }

    }
}
