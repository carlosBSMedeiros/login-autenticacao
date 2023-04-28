using FluentNHibernate.Mapping;
using LoginAutenticacao.Dominio.Usuarios.Entidades;

namespace LoginAutenticacao.Infra.Usuarios.Mapeamentos
{
    public class UsuarioMap : ClassMap<Usuario>
    {
        public UsuarioMap()
        {
            Table("usuario");
            Id(x => x.Id).Column("ID").GeneratedBy.Identity();
            Map(u => u.Nome, "nome");
            Map(u => u.Email, "email");
            Map(u => u.Login, "login");
            Map(u => u.Senha, "senha");
            Map(u => u.DataCriacao, "create_at");
            Map(u => u.DataAtualizacao, "update_at");
        }
    }
}
