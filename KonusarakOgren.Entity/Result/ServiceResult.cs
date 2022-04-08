
namespace KonusarakOgren.Entity.Result
{
    public class ServiceResult<TEntity> where TEntity : class
    {
        public ResultStatus Status { get; set; }
        public string Message { get; set; }
        public TEntity? Data { get; set; }
    }
}
