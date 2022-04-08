using System.Net;

namespace KonusarakOgren.Entity.Result
{
    public class ApiResult<TEntity> where TEntity : class
    {
        public TEntity? Data { get; set; }
        public HttpStatusCode StatusCode { get; set; }
        public HttpResponseMessage Response { get; set; }
        public Exception? Exception { get; set; }
        public string? ExceptionMessage { get; set; }
        public string? Message { get; set; }
    }
}
