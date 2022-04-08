using KonusarakOgren.DataAccess.Abstract;
using KonusarakOgren.Entity.SqlLiteKonusarakOgren.Entities.Article;

namespace KonusarakOgren.Business.Abstract
{
    public interface IArticleService : IGenericRepository<Article>
    {
    }
}
