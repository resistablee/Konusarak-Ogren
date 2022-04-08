using KonusarakOgren.Business.Abstract;
using KonusarakOgren.Entity.SqlLiteKonusarakOgren.Entities.Article;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace KonusarakOgren.Api.Controllers
{
    public class ArticleController : BaseApiController
    {
        private readonly IArticleService _articleService;

        public ArticleController(IArticleService articleService) => _articleService = articleService;

        [HttpGet]
        [Authorize(Roles = "Admin")]
        public async Task<IActionResult> GetAll()
        {
            var result = await _articleService.GetAllAsync();

            if (result == null)
                return NoContent();

            return Ok(result);
        }

        [HttpPost]
        [Authorize(Roles = "Admin")]
        public async Task<IActionResult> Create([FromBody] Article request)
        {
            var result = await _articleService.InsertAsync(request);

            if (result != null)
                return StatusCode(201);

            return StatusCode(500);
        }

        [HttpGet("{id}")]
        [Authorize(Roles = "Admin")]
        public async Task<IActionResult> Get(int id)
        {
            var result = await _articleService.FindOneWithAsNoTrackingAsync(x=>x.Id == id);

            if (result == null)
                return NoContent();

            return Ok(result);
        }
    }
}
