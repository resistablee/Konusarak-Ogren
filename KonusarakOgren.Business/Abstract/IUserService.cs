using KonusarakOgren.DataAccess.Abstract;
using KonusarakOgren.Entity.Contract;
using KonusarakOgren.Entity.Request;
using KonusarakOgren.Entity.Result;
using KonusarakOgren.Entity.SqlLiteKonusarakOgren.Entities.User;

namespace KonusarakOgren.Business.Abstract
{
    public interface IUserService : IGenericRepository<User>
    {
        Task<ServiceResult<AccessTokenContract>> GetTokenAsync(GetTokenContractServiceRequest request);
    }
}
