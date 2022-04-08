using KonusarakOgren.Business.Abstract;
using KonusarakOgren.DataAccess.Concrete;
using KonusarakOgren.DataAccess.Context;
using KonusarakOgren.Entity.SqlLiteKonusarakOgren.Entities.Question;

namespace KonusarakOgren.Business.Concrete
{
    public class AnswerService : GenericRepository<Answer>, IAnswerService
    {
        private readonly KonusarakOgrenContext _context;

        public AnswerService(KonusarakOgrenContext context) : base(context) => _context = context;
    }
}
