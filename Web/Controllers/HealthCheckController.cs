using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace Web.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class HealthCheckController : Controller
    {
        [HttpGet]
        public ActionResult<string> Get()
        {
            return Ok("API rodando!");
        }

        /// <summary>
        /// Testa autenticação
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        [Authorize(Roles ="free")]
        [Route("teste-autenticacao")]
        public ActionResult GetAutenticado()
        {
            return Ok($" Autenticado!");
        }
    }
}
