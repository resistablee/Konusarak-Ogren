using KonusarakOgren.Entity.SqlLiteKonusarakOgren.Entities.Article;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;

namespace KonusarakOgren.Web.Controllers
{
    public class ArticleController : Controller
    {
        [HttpGet("Article")]
        [Authorize(Roles = "Admin")]
        public async Task<IActionResult> Index()
        {
            var response = await ApiRequest<List<Article>>.SendRequest("Article", HttpContext.Session.GetString("token"));

            if (response.StatusCode == System.Net.HttpStatusCode.Unauthorized)
            {
                return RedirectToAction("Logout", "User");
            }

            return View(response.Data);
        }

        [HttpGet("Article/{id}")]
        [Authorize(Roles = "Admin")]
        public async Task<string> GetById(int id)
        {
            var response = ApiRequest<Article>.SendRequest("Article/" + id, HttpContext.Session.GetString("token")).Result;

            return response.Data.Text;
        }
    }
}
