using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PortifolioAPI.Models
{
    public class Usuario
    {
        public Usuario() { }                //Se não declararmos esse construtor vazio a API retorna um BadRequest "Deserialization of reference types without parameterless constructor is not supported"

        public int UsuarioId { get; set; }
        public string Nome { get; set; }
        public string Email { get; set; }
        public string Apresentacao { get; set; }

        public Usuario(string nome, string email, string apresentacao)
        {
            this.Nome = nome;
            this.Email = email;
            this.Apresentacao = apresentacao;
        }
    }
}
