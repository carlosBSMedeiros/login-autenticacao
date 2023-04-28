using LoginAutenticacao.Dominio.Utils.Entidades;
using NHibernate;

namespace LoginAutenticacao.Infra.Utils.Repositorios
{
    public class RepositorioNHibernate<T> where T : EntidadeBase
    {
        private readonly ISession session;

        public RepositorioNHibernate(NHibernate.ISession session) => this.session = session;

        public void Inserir(T entidade)
        {
            session.Save(entidade);
        }

        public void Editar(T entidade)
        {
            session.Update(entidade);
        }

        public void Deletar(T entidade)
        {
            session.Delete(entidade);
        }

        public void Deletar(int id)
        {
            var entidade = session.Get<T>(id);
            this.Deletar(entidade);
        }
        public IQueryable<T> Query()
        {
            return session.Query<T>();
        }

        public T Recuperar(int id)
        {
            return session.Get<T>(id);
        }
    }
}
