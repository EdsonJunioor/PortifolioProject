using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PortifolioAPI.Models
{
    public class Usuario
    {
        public Usuario(int Id, string Nome, int Idade, string Email, string Descricao, string Habilidades)
        {
            this.Id = Id;
            this.Nome = Nome;
            this.Idade = Idade;
            this.Email = Email;
            this.Descricao = Descricao;
            this.Habilidades = Habilidades;
        }

        public int Id { get; set; }
        public string Nome { get; set; }
        public int Idade { get; set; }
        public string Email { get; set; }
        public string Descricao { get; set; }
        public string Habilidades { get; set; }
    }
}
