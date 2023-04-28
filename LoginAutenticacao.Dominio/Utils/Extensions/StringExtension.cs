using LoginAutenticacao.Dominio.Utils.Excecoes;

namespace LoginAutenticacao.Dominio.Utils.Extensions
{
    public static class StringExtension
    {
        public static void VerificarAtributo(this string valor, string atributo)
        {
            if (string.IsNullOrEmpty(valor))
            {
                throw new AtributoObrigatorioExcecao(atributo);
            }
        }
    }
}
