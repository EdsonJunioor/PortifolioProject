using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PortifolioAPI.Models
{
    public class Qualificacao
    {
        public Qualificacao() { }

        public int QualificacaoId { get; set; }
        public Usuario usuario { get; set; }
        public int UsuarioId { get; set; }
        public string Descricao { get; set; }

        public Qualificacao(int usuarioId, string descricao)
        {
            this.UsuarioId = usuarioId;
            this.Descricao = descricao;
        }
    }
}
