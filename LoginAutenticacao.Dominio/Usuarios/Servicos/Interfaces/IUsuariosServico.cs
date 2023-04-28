using LoginAutenticacao.Dominio.Usuarios.Entidades;

namespace LoginAutenticacao.Dominio.Usuarios.Servicos.Interfaces
{
    public  interface IUsuariosServico
    {
        Usuario Validar(int id);
        Usuario Instanciar(string nome, string email, string login, string senha);
        void Inserir(Usuario usuario);
        Usuario ValidarParaAutenticacao(string email, string senha);
    }
}
