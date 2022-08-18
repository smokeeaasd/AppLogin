using System;
using System.Collections.Generic;
using System.Text;

namespace AppLogin.Model
{
    internal class DadosUsuario
    {
        public string Email;
        public string Senha;
        public DadosUsuario(string email, string senha)
        {
            Email = email;
            Senha = senha;
        }
    }

    internal class Usuarios
    {
        static List<DadosUsuario> ListaUsuarios = new List<DadosUsuario>
        {
            new DadosUsuario("victorvendrameto@gmail.com", "furry123"),
            new DadosUsuario("adibinho@gmail.com", "adibinho")
        };
    }
}
