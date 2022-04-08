using KonusarakOgren.DataAccess.Abstract;
using KonusarakOgren.Entity.Response;
using KonusarakOgren.Entity.Result;
using KonusarakOgren.Entity.SqlLiteKonusarakOgren.Entities.Exam;

namespace KonusarakOgren.Business.Abstract
{
    public interface IExamService : IGenericRepository<Exam>
    {
        Task<ServiceResult<CreateExamResponse>> CreateExam();
        Task<ServiceResult<List<UserExamResponse>>> UserExam(int userId);
    }
}
