using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PortifolioAPI.Models
{
    public class Login
    {
        public Login() { }

        public int LoginId { get; set; }
        public Usuario usuario { get; set; }
        public int UsuarioId { get; set; }
        public string Email { get; set; }
        public string Senha { get; set; }

        public Login(int usuarioId, string email, string senha)
        {
            this.UsuarioId = usuarioId;
            this.Email = email;
            this.Senha = senha;
        }
    }
}
