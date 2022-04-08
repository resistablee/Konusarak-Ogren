using KonusarakOgren.DataAccess.Abstract;
using KonusarakOgren.Entity;
using KonusarakOgren.Entity.Request;
using KonusarakOgren.Entity.Result;
using KonusarakOgren.Entity.SqlLiteKonusarakOgren.Entities.Question;

namespace KonusarakOgren.Business.Abstract
{
    public interface IQuestionService : IGenericRepository<Question>
    {
        Task<ServiceResult<List<ArticleQuestion>>> CreateAsync(CreateQuestionRequest request);
    }
}
