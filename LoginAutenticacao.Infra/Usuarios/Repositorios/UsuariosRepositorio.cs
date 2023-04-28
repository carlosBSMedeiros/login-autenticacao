using LoginAutenticacao.Dominio.Usuarios.Entidades;
using LoginAutenticacao.Dominio.Usuarios.Repositorios;
using LoginAutenticacao.Infra.Utils.Repositorios;
using NHibernate;

namespace LoginAutenticacao.Infra.Usuarios.Repositorios
{
    public class UsuariosRepositorio : RepositorioNHibernate<Usuario>, IUsuariosRepositorio
    {
        public UsuariosRepositorio(ISession session) : base(session)
        {

        }
    }
}
