using LoginAutenticacao.Aplicacao.Usuarios.Servicos.Interfaces;
using LoginAutenticacao.DataTransfer.Autenticacoes.Request;
using LoginAutenticacao.DataTransfer.Auth.Response;
using Microsoft.AspNetCore.Mvc;

namespace LoginAutenticacao.Web.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class AutenticacoesController : Controller
    {
        private readonly IUsuariosAppServico usuariosAppServico;

        public AutenticacoesController(IUsuariosAppServico usuariosAppServico)
        {
            this.usuariosAppServico = usuariosAppServico;
        }

        /// <summary>
        /// Realiza autenticação do usuário por email e senha
        /// </summary>
        /// <param name="request""></param>
        /// <returns></returns>
        [HttpPost]
        public ActionResult<AutenticacaoResponse> Login(AutenticacaoRequest request)
        {
            return Ok(usuariosAppServico.Autenticar(request));
        }
    }
}
