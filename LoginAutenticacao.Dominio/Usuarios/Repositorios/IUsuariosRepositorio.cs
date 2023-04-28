using LoginAutenticacao.Dominio.Usuarios.Entidades;
using LoginAutenticacao.Dominio.Utils.Repositorios;

namespace LoginAutenticacao.Dominio.Usuarios.Repositorios
{
    public interface IUsuariosRepositorio : IRepositorioNHibernate<Usuario>
    {
    }
}
