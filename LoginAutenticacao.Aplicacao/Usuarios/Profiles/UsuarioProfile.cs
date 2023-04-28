using AutoMapper;
using LoginAutenticacao.Dominio.Usuarios.Entidades;
using LoginAutenticacao.DataTransfer.Usuarios.Response;

namespace LoginAutenticacao.Aplicacao.Usuarios.Profiles
{
    public class UsuarioProfile : Profile
    {
        public UsuarioProfile()
        {
            CreateMap<Usuario, UsuarioResponse>();
        }
    }
}
