using KonusarakOgren.Entity.Contract;
using KonusarakOgren.Entity.DTO;
using KonusarakOgren.Entity.Result;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System.Security.Claims;

namespace KonusarakOgren.Web.Controllers
{
    public class UserController : Controller
    {
        [HttpGet("Login")]
        public IActionResult Login()
        {
            return View();
        }

        [HttpPost("Login")]
        [AllowAnonymous]
        public async Task<JsonResult> Login(LoginDTO login)
        {
            if (!ModelState.IsValid)
            {
                return Json(0);
            }

            var response = await ApiRequest<ServiceResult<AccessTokenContract>>.SendRequest("User/Login", String.Empty, login);

            if (response == null)
                return Json(3);

            if (response.StatusCode == System.Net.HttpStatusCode.OK)
            {
                //var token = await response.Content.ReadAsStringAsync();
                //var result = JsonConvert.DeserializeObject<ServiceResult<AccessTokenContract>>(token);

                HttpContext.Session.SetString("token", response.Data.Data.AccessToken);

                var tokenContent = TokenManager.ReadPayload(response.Data.Data.AccessToken);

                ClaimsIdentity identity = new ClaimsIdentity(new[]
                {
                    new Claim(ClaimTypes.NameIdentifier, tokenContent.Payload.FirstOrDefault(x => x.Key == "nameid").Value.ToString()),
                    new Claim(ClaimTypes.Name, tokenContent.Payload.FirstOrDefault(x => x.Key == "name").Value.ToString()),
                    new Claim(ClaimTypes.Surname, tokenContent.Payload.FirstOrDefault(x => x.Key == "family_name").Value.ToString()),
                    new Claim(ClaimTypes.Email, tokenContent.Payload.FirstOrDefault(x => x.Key == "email").Value.ToString()),
                    new Claim(ClaimTypes.Role, tokenContent.Payload.FirstOrDefault(x => x.Key == "role").Value.ToString()),
                },
                CookieAuthenticationDefaults.AuthenticationScheme);

                var principal = new ClaimsPrincipal(identity);
                var signInResult = HttpContext.SignInAsync(CookieAuthenticationDefaults.AuthenticationScheme,principal, new AuthenticationProperties
                {
                    ExpiresUtc = DateTime.UtcNow.AddMinutes(15),
                    IssuedUtc = DateTime.UtcNow,
                });

                //if (signInResult.Exception == null)
                //{
                //    return RedirectToAction("Error", "Home");
                //}

                return Json(1);
            }

            else if (response.StatusCode == System.Net.HttpStatusCode.NoContent)
                return Json(2);

            else
                return Json(3);
        }

        [HttpGet("Logout")]
        [AllowAnonymous]
        public async Task<ActionResult> Logout()
        {
            HttpContext.Session.Clear();
            await HttpContext.SignOutAsync();

            return RedirectToAction("Login");
        }
    }
}
