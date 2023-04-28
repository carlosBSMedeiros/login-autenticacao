using LoginAutenticacao.DataTransfer.Autenticacoes.Request;
using LoginAutenticacao.DataTransfer.Auth.Response;
using LoginAutenticacao.DataTransfer.Usuarios.Request;
using LoginAutenticacao.DataTransfer.Usuarios.Response;

namespace LoginAutenticacao.Aplicacao.Usuarios.Servicos.Interfaces
{
    public interface IUsuariosAppServico 
    {
        UsuarioResponse Recuperar(int id);
        UsuarioResponse Inserir(UsuarioInserirRequest request);
        AutenticacaoResponse Autenticar(AutenticacaoRequest request);
    }
}
