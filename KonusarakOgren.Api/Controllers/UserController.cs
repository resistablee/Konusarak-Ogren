using KonusarakOgren.Business.Abstract;
using KonusarakOgren.Entity.Contract;
using KonusarakOgren.Entity.Request;
using KonusarakOgren.Entity.SqlLiteKonusarakOgren.Entities.User;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace KonusarakOgren.Api.Controllers
{
    public class UserController : BaseApiController
    {
        private readonly IUserService _userService;

        public UserController(IUserService userService) => _userService = userService;

        [AllowAnonymous]
        [HttpPost("Login")]
        public async Task<ActionResult> Login([FromBody] GetTokenContractServiceRequest request)
        {
            var result = await _userService.GetTokenAsync(request);

            if (result.Status == Entity.Result.ResultStatus.ResourceNotFound)
                return NoContent();

            else if (result.Status == Entity.Result.ResultStatus.Successful)
                return Ok(result);

            else
                return BadRequest();
        }

        [AllowAnonymous]
        [HttpPost("Register")]
        public async Task<ActionResult> Register([FromBody] User request)
        {
            var result = await _userService.InsertAsync(request);

            if (result != null)
                return StatusCode(201);

            return StatusCode(500);
        }
    }
}
