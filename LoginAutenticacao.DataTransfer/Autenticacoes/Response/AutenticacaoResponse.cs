using LoginAutenticacao.DataTransfer.Usuarios.Response;

namespace LoginAutenticacao.DataTransfer.Auth.Response
{
    public class AutenticacaoResponse
    {
        public UsuarioResponse Usuario { get; set; }
        public string Token { get; set; }

    }
}
