using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PortifolioAPI.Models
{
    public class ExperienciaProfissional
    {
        public int ExpProfId { get; set; }
        public Usuario usuario { get; set; }
        public int UsuarioId { get; set; }
        public string Empresa { get; set; }
        public string Cargo { get; set; }
        public DateTime DtAdmissao { get; set; }
        public DateTime DtDemissao { get; set; }
        public string Atual { get; set; }
        public string Atribuicao { get; set; }

        public ExperienciaProfissional(int usuarioId, string empresa, string cargo, DateTime dtAdmissao, DateTime dtDemissao, string atual, string atribuicao)
        {
            this.UsuarioId = usuarioId;
            this.Empresa = empresa;
            this.Cargo = cargo;
            this.DtAdmissao = dtAdmissao;
            this.DtDemissao = dtDemissao;
            this.Atual = atual;
            this.Atribuicao = atribuicao;
        }
    }
}
