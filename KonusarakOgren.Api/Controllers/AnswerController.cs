using KonusarakOgren.Business.Abstract;
using KonusarakOgren.Entity.SqlLiteKonusarakOgren.Entities.Question;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace KonusarakOgren.Api.Controllers
{
    public class AnswerController : BaseApiController
    {
        private readonly IAnswerService _answerService;

        public AnswerController(IAnswerService answerService) => _answerService = answerService;
    }
}
