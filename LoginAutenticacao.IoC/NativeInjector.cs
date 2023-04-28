using FluentNHibernate.Cfg;
using LoginAutenticacao.Aplicacao.Usuarios.Profiles;
using LoginAutenticacao.Aplicacao.Usuarios.Servicos;
using LoginAutenticacao.Dominio.Usuarios.Servicos;
using LoginAutenticacao.Dominio.Utils.Transacoes;
using LoginAutenticacao.Infra.Usuarios.Mapeamentos;
using LoginAutenticacao.Infra.Usuarios.Repositorios;
using LoginAutenticacao.Infra.Utils.Transacoes;
using Microsoft.Extensions.DependencyInjection;
using System.Reflection;

namespace LoginAutenticacao.IoC
{
    public class NativeInjector
    {
        public static void RegisterServices(IServiceCollection services, string connectionString)
        {
            var config = Fluently.Configure().Database(() =>
            {
                return FluentNHibernate.Cfg.Db.MySQLConfiguration.Standard
                .FormatSql()
                .ShowSql()
                .ConnectionString(connectionString);
            })
                .Mappings(m => m.FluentMappings.AddFromAssemblyOf<UsuarioMap>())
                .CurrentSessionContext("call");

            var sessionFactory = config.BuildSessionFactory();

            services.AddSingleton(sessionFactory);
            services.AddScoped(factory => sessionFactory.OpenSession());
            services.AddScoped<IUnitOfWork, UnitOfWork>();
            services.AddScoped<IUnitOfWork, UnitOfWork>();

            services.AddAutoMapper(typeof(UsuarioProfile).GetTypeInfo().Assembly);

            services.Scan(scan => scan
                .FromAssemblyOf<UsuariosAppServico>()
                    .AddClasses()
                        .AsImplementedInterfaces()
                        .WithScopedLifetime());

            services.Scan(scan => scan
                .FromAssemblyOf<UsuariosRepositorio>()
                    .AddClasses()
                        .AsImplementedInterfaces()
                        .WithScopedLifetime());

            services.Scan(scan => scan
                .FromAssemblyOf<UsuariosServico>()
                    .AddClasses()
                        .AsImplementedInterfaces()
                        .WithScopedLifetime());

        }
    }

}

