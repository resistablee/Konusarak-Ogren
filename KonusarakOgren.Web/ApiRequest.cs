using KonusarakOgren.Entity.Result;
using Newtonsoft.Json;
using System.Net.Http.Headers;
using System.Text;

namespace KonusarakOgren.Web
{
    public class ApiRequest<TEntity> where TEntity : class
    {
        static readonly HttpClient client = new HttpClient()
        {
            BaseAddress = new Uri("https://localhost:7053/")
        };

        public static async Task<ApiResult<TEntity>> SendRequest(string requestUri, string token, object entity)
        {
            HttpResponseMessage response = null;

            if (client.DefaultRequestHeaders.Accept == null)
                client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));

            if (!String.IsNullOrEmpty(token) && client.DefaultRequestHeaders.Authorization == null)
                client.DefaultRequestHeaders.Add("Authorization", "Bearer " + token);

            var json = JsonConvert.SerializeObject(entity);
            var data = new StringContent(json, Encoding.UTF8, "application/json");

            try
            {
                response = await client.PostAsync("api/" + requestUri, data);
            }
            catch (Exception ex)
            {
                return new ApiResult<TEntity>()
                {
                    Exception = ex,
                    ExceptionMessage = ex.Message
                };
            }

            var jsonData = await response.Content.ReadAsStringAsync();
            var resultData = JsonConvert.DeserializeObject<TEntity>(jsonData);

            return new ApiResult<TEntity>()
            {
                Response = response,
                StatusCode = response.StatusCode,
                Data = resultData
            };
        }

        public static async Task<ApiResult<TEntity>> SendRequest(string requestUri, string token)
        {
            HttpResponseMessage response = null;

            if (client.DefaultRequestHeaders.Accept != null)
                client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));

            if (!String.IsNullOrEmpty(token) && client.DefaultRequestHeaders.Authorization == null)
                client.DefaultRequestHeaders.Add("Authorization", "Bearer " + token);

            try
            {
                response = await client.GetAsync("api/" + requestUri);
            }
            catch (Exception ex)
            {
                return new ApiResult<TEntity>()
                {
                    Exception = ex,
                    ExceptionMessage = ex.Message
                };
            }

            var jsonData = await response.Content.ReadAsStringAsync();
            var resultData = JsonConvert.DeserializeObject<TEntity>(jsonData);

            return new ApiResult<TEntity>()
            {
                Response = response,
                StatusCode = response.StatusCode,
                Data= resultData
            };
        }

        public static async Task<HttpResponseMessage> SendDeleteRequest(string requestUri, int id, string token)
        {
            HttpResponseMessage response = null;

            if (client.DefaultRequestHeaders.Accept != null)
                client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));

            if (!String.IsNullOrEmpty(token) && client.DefaultRequestHeaders.Authorization == null)
                client.DefaultRequestHeaders.Add("Authorization", "Bearer " + token);

            try
            {
                response = await client.DeleteAsync("api/" + requestUri + "/" + id);
            }
            catch (Exception ex)
            {
                return response;
            }

            return response;
        }
    }
}
