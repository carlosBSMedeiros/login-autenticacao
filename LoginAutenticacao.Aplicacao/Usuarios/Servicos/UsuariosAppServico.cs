using AutoMapper;
using LoginAutenticacao.Aplicacao.Usuarios.Servicos.Interfaces;
using LoginAutenticacao.DataTransfer.Autenticacoes.Request;
using LoginAutenticacao.DataTransfer.Auth.Response;
using LoginAutenticacao.DataTransfer.Usuarios.Request;
using LoginAutenticacao.DataTransfer.Usuarios.Response;
using LoginAutenticacao.Dominio.Usuarios.Servicos.Interfaces;
using LoginAutenticacao.Dominio.Utils.Transacoes;
using LoginAutenticacao.Infra.Autenticacoes.Servicos.Interfaces;

namespace LoginAutenticacao.Aplicacao.Usuarios.Servicos
{
    public class UsuariosAppServico : IUsuariosAppServico
    {
        private readonly IUsuariosServico usuariosServicos;
        private readonly IAutenticacoesServico autenticacoesServico;
        private readonly IMapper mapper;
        private readonly IUnitOfWork unitOfWork;

        public UsuariosAppServico(IUsuariosServico usuariosServicos,
                                IAutenticacoesServico autenticacoesServico,
                                IMapper mapper,
                                IUnitOfWork unitOfWork
            )
        {
            this.usuariosServicos = usuariosServicos;
            this.autenticacoesServico = autenticacoesServico;
            this.mapper = mapper;
            this.unitOfWork = unitOfWork;
        }

        public UsuarioResponse Recuperar(int id)
        {
            var usuario = usuariosServicos.Validar(id);
            return mapper.Map<UsuarioResponse>(usuario);
        }

        public UsuarioResponse Inserir(UsuarioInserirRequest request)
        {
            try
            {
                unitOfWork.BeginTransaction();

                var novoUsuario = usuariosServicos.Instanciar(request.Nome, request.Email, request.Login, request.Senha);
                usuariosServicos.Inserir(novoUsuario);

                unitOfWork.Commit();

                return mapper.Map<UsuarioResponse>(novoUsuario);
            }
            catch 
            {
                unitOfWork.Rollback();
                throw;
            }
        }

        public AutenticacaoResponse Autenticar(AutenticacaoRequest request)
        {
            var usuario = usuariosServicos.ValidarParaAutenticacao(request.Email, request.Senha);

            var token = autenticacoesServico.GerarToken(usuario);

            var usuarioResponse = mapper.Map<UsuarioResponse>(usuario);

            return new AutenticacaoResponse() { Usuario = usuarioResponse, Token = token };
                    }
    }
}
