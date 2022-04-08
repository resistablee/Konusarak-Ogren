using KonusarakOgren.Business.Abstract;
using KonusarakOgren.Entity.Request;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace KonusarakOgren.Api.Controllers
{
    public class QuestionController : BaseApiController
    {
        private readonly IQuestionService _questionService;

        public QuestionController(IQuestionService questionService) => _questionService = questionService;


        [HttpGet]
        [Authorize(Roles = "Admin")]
        public async Task<IActionResult> GetAll()
        {
            var result = await _questionService.GetAllAsync();

            if (result == null)
                return NoContent();

            return Ok(result);
        }

        [HttpGet("{id}")]
        [Authorize(Roles = "Admin")]
        public async Task<IActionResult> Get(int id)
        {
            var result = await _questionService.FindOneWithAsNoTrackingAsync(x => x.Id == id);

            if (result == null)
                return NoContent();            

            return Ok(result);
        }

        [HttpPost]
        [Authorize(Roles = "Admin")]
        public async Task<IActionResult> Create([FromBody] CreateQuestionRequest request)
        {
            var result = await _questionService.CreateAsync(request);

            if (result != null)
                return StatusCode(201);

            return StatusCode(500);
        }
    }
}
