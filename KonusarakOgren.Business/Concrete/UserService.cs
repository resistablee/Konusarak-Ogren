using KonusarakOgren.Business.Abstract;
using KonusarakOgren.Business.Auth;
using KonusarakOgren.DataAccess.Concrete;
using KonusarakOgren.DataAccess.Context;
using KonusarakOgren.Entity.Contract;
using KonusarakOgren.Entity.Request;
using KonusarakOgren.Entity.Result;
using KonusarakOgren.Entity.SqlLiteKonusarakOgren.Entities.User;

namespace KonusarakOgren.Business.Concrete
{
    public class UserService : GenericRepository<User>, IUserService
    {
        private readonly KonusarakOgrenContext _context;

        public UserService(KonusarakOgrenContext context) : base(context)
        {
            _context = context;
        }

        public async Task<ServiceResult<AccessTokenContract>> GetTokenAsync(GetTokenContractServiceRequest request)
        {
            //var entity = await _userService.FindOneAsync(p => p.Email.ToLower().Equals(request.Email.ToLower()) && p.Password.ToLower().Equals(request.Password.ToLower()) && !p.IsDeleted);
            var entity = await FindOneWithAsNoTrackingAsync(p => p.Email.ToLower().Equals(request.Email.ToLower()) && p.Password.ToLower().Equals(request.Password.ToLower()) && !p.IsDeleted);

            if (entity == null)
            {
                return new ServiceResult<AccessTokenContract>
                {
                    Status = ResultStatus.ResourceNotFound,
                    Message = "Username or password is incorrect.",
                };
            }

            var token = new JwtManager().Generate(entity);

            return new ServiceResult<AccessTokenContract>
            {
                Status = ResultStatus.Successful,
                Message = "Login successfull",
                Data = token
            };
        }
    }
}
