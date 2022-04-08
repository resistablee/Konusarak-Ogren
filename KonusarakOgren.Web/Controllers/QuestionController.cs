using KonusarakOgren.Entity.Request;
using KonusarakOgren.Entity.SqlLiteKonusarakOgren.Entities.Article;
using KonusarakOgren.Entity.SqlLiteKonusarakOgren.Entities.Question;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Newtonsoft.Json;

namespace KonusarakOgren.Web.Controllers
{
    public class QuestionController : Controller
    {
        [HttpGet("Question/Create")]
        [Authorize(Roles = "Admin")]
        public async Task<IActionResult> Create()
        {
            var response = await ApiRequest<List<Article>>.SendRequest("Article", HttpContext.Session.GetString("token"));

            if (response.StatusCode == System.Net.HttpStatusCode.Unauthorized)
            {
                return RedirectToAction("Logout", "User");
            }

            ViewBag.ArticleList = new SelectList(response.Data, "Id", "Title");

            ViewBag.Articles = response.Data;

            ViewBag.Answers = new List<SelectListItem>
            {
                new SelectListItem { Text = "A", Value = "0"},
                new SelectListItem { Text = "B", Value = "1"},
                new SelectListItem { Text = "C", Value = "2"},
                new SelectListItem { Text = "D", Value = "3"}
            };

            return View();
        }

        [HttpPost("Question/Create")]  
        [Authorize(Roles = "Admin")]
        public async Task<JsonResult> Create(CreateQuestionRequest request)
        {
            var response = await ApiRequest<Question>.SendRequest("Question", HttpContext.Session.GetString("token"), request);
            if (response.Response.IsSuccessStatusCode)
            {
                return Json(1);
            }
            else if (response.StatusCode == System.Net.HttpStatusCode.BadRequest)
            {
                return Json(2);
            }

            return Json(0);
        }
    }
}
