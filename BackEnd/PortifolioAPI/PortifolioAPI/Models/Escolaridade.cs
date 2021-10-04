using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PortifolioAPI.Models
{
    public class Escolaridade
    {
        public Escolaridade() { }
        public int EscolaridadeId { get; set; }
        public Usuario usuario { get; set; }
        public int UsuarioId { get; set; }
        public string Formacao { get; set; }
        public string Instituicao { get; set; }
        public string Curso { get; set; }
        public DateTime DtInicio { get; set; }
        public DateTime DtConclusaoPrevista { get; set; }

        public Escolaridade(int usuarioId,string formacao, string instituicao, string curso, DateTime dtInicio, DateTime dtConclusaoPrevista)
        {
            this.UsuarioId = usuarioId;
            this.Formacao = formacao;
            this.Instituicao = instituicao;
            this.Curso = curso;
            this.DtInicio = dtInicio;
            this.DtConclusaoPrevista = dtConclusaoPrevista;
        }
    }
}
