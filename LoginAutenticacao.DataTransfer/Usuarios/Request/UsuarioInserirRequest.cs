﻿namespace LoginAutenticacao.DataTransfer.Usuarios.Request
{
    public class UsuarioInserirRequest
    {
        public string Nome { get; set; }
        public string Login { get; set; }
        public string Senha { get; set; }
        public string Email { get; set; }
    }
}
