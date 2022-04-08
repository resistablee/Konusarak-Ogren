using KonusarakOgren.Entity.Response;
using KonusarakOgren.Entity.Result;
using KonusarakOgren.Entity.SqlLiteKonusarakOgren.Entities.Exam;
using KonusarakOgren.Entity.SqlLiteKonusarakOgren.Entities.Question;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using System.Security.Claims;

namespace KonusarakOgren.Web.Controllers
{
    public class ExamController : Controller
    {
        private static List<Answer> answerList;

        [HttpGet("MyExam")]
        [Authorize(Roles = "User")]
        public async Task<IActionResult> GetUserExam()
        {
            int userID = Convert.ToInt32(HttpContext.User.Claims.FirstOrDefault(x => x.Type == ClaimTypes.NameIdentifier)?.Value);

            var response = await ApiRequest<ServiceResult<List<UserExamResponse>>>.SendRequest("Exam/User/" + userID + "/MyExam", HttpContext.Session.GetString("token"));

            if (response.StatusCode == System.Net.HttpStatusCode.Unauthorized)
                return RedirectToAction("Logout", "User");

            return View(response.Data.Data);
        }

        [HttpGet("Exam")]
        [Authorize(Roles = "User")]
        public async Task<IActionResult> TakeTheExam()
        {
            var response = await ApiRequest<ServiceResult<CreateExamResponse>>.SendRequest("Exam/CreateQuiz", HttpContext.Session.GetString("token"));

            answerList = new List<Answer>();

            foreach (var item in response.Data.Data.Questions)
            {
                answerList.AddRange(item.Answers);
            }

            return View(response.Data.Data);
        }

        [HttpPost("/Exam/Delete/{id}")]
        [Authorize(Roles = "User")]
        public async Task<IActionResult> DeleteUserExam(int id)
        {
            var response = await ApiRequest<Exam>.SendDeleteRequest("Exam", id, HttpContext.Session.GetString("token"));

            return RedirectToAction("GetUserExam");
        }

        [HttpGet("AnswerIsTrue/{id}")]
        [Authorize(Roles = "User")]
        public bool AnswerIsTrue(int id)
        {
            var data = answerList.FirstOrDefault(x => x.Id == id);
            if (data == null)
            {
                return false;
            }

            return (bool)data.IsTrue;
        }

        [HttpPost("AddUserExam/{id}")]
        [Authorize(Roles = "User")]
        public async Task AddUserExam(int id)
        {
            int userID = Convert.ToInt32(HttpContext.User.Claims.FirstOrDefault(x => x.Type == ClaimTypes.NameIdentifier)?.Value);

            var response = await ApiRequest<Exam>.SendRequest("Exam", HttpContext.Session.GetString("token"), new Exam
            {
                ArticleID = id,
                UserID = userID,
                ExamDate = DateTime.UtcNow,
            });
        }
    }
}
