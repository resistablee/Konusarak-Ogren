using KonusarakOgren.Business.Abstract;
using KonusarakOgren.DataAccess.Concrete;
using KonusarakOgren.DataAccess.Context;
using KonusarakOgren.Entity.SqlLiteKonusarakOgren.Entities.Article;

namespace KonusarakOgren.Business.Concrete
{
    public class ArticleService : GenericRepository<Article>, IArticleService
    {
        private readonly KonusarakOgrenContext _context;

        public ArticleService(KonusarakOgrenContext context) : base(context)  => _context = context;
    }
}
