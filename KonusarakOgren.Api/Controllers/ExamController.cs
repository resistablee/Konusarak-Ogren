using KonusarakOgren.Business.Abstract;
using KonusarakOgren.Entity.SqlLiteKonusarakOgren.Entities.Exam;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace KonusarakOgren.Api.Controllers
{
    public class ExamController : BaseApiController
    {
        private readonly IExamService _examService;

        public ExamController(IExamService examService) => _examService = examService;

        [HttpGet]
        [Authorize(Roles = "User")]
        public async Task<IActionResult> Get()
        {
            var result = await _examService.GetAllWithAsNoTrackingAsync();

            if (result == null)
                return NoContent();

            return Ok(result);
        }

        [HttpGet("CreateQuiz")]
        [Authorize(Roles = "User")]
        public async Task<IActionResult> Create()
        {
            var result = await _examService.CreateExam();

            if (result == null)
                return NoContent();

            return Ok(result);
        }

        [HttpGet("User/{id}/MyExam")]
        [Authorize(Roles = "User")]
        public async Task<IActionResult> GetUserExams(int id)
        {
            var result = await _examService.UserExam(id);

            if (result == null)
                return NoContent();

            return Ok(result);
        }

        [HttpDelete("{id}")]
        [Authorize(Roles = "User")]
        public async Task<IActionResult> Delete(int id)
        {
            await _examService.DeleteAsync(id);

            return Ok();
        }

        [HttpPost]
        [Authorize(Roles = "User")]
        public async Task<IActionResult> AddUserExam([FromBody] Exam request)
        {
            var result = await _examService.InsertAsync(request);

            if (result != null)
                return StatusCode(201);

            return StatusCode(500);
        }
    }
}
