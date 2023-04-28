using System.Runtime.Serialization;

namespace LoginAutenticacao.Dominio.Utils.Excecoes
{
    public class RegraDeNegocioExcecao : Exception, ISerializable
    {
        public RegraDeNegocioExcecao() { }

        public RegraDeNegocioExcecao(string mensagem) : base(mensagem) { }
    }
}
