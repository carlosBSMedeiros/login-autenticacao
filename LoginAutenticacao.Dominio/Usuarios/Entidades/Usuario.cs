using LoginAutenticacao.Dominio.Utils.Entidades;
using LoginAutenticacao.Dominio.Utils.Extensions;

namespace LoginAutenticacao.Dominio.Usuarios.Entidades
{
    public class Usuario : EntidadeBase
    {
        public virtual string Nome { get; protected set; } 
        public virtual string Email { get; protected set; } 
        public virtual string Login { get; protected set; } 
        public virtual string Senha { get; protected set; } 
        public virtual DateTime DataCriacao { get; protected set; } 
        public virtual DateTime? DataAtualizacao { get; protected set; } 

        protected Usuario() { }

        public Usuario(string nome, string email, string login, string senha)
        {
            SetNome(nome);
            SetEmail(email);
            SetLogin(login);
            SetSenha(senha);
            SetDataCriacao(DateTime.Now);
        }

        public virtual void SetNome(string nome)
        {
            nome.VerificarAtributo("Nome");
            this.Nome = nome;
        }

        public virtual void SetEmail(string email)
        {
            email.VerificarAtributo("Email");
            this.Email = email;
        }

        public virtual void SetLogin(string login)
        {
            login.VerificarAtributo("Login");
            this.Login = login;
        }

        public virtual void SetSenha(string senha)
        {
            senha.VerificarAtributo("Senha");
            this.Senha = senha;
        }

        public virtual void SetDataCriacao(DateTime dataCriacao)
        {
            this.DataCriacao = dataCriacao;
        }

        public virtual void SetDataAtualizacao(DateTime dataAtualizacao)
        {
            this.DataAtualizacao = dataAtualizacao;
        }
    }
}
