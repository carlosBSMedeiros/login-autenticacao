using LoginAutenticacao.Dominio.Usuarios.Entidades;

namespace LoginAutenticacao.Infra.Autenticacoes.Servicos.Interfaces
{
    public interface IAutenticacoesServico
    {
        public string GerarToken(Usuario usuario);
    }
}
