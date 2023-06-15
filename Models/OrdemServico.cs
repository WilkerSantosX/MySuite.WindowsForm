using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    public class OrdemServico
    {
        public int CodOrdemServico { get; set; }

        public string Assunto { get; set; }

        public string Descricao { get; set; }

        public int CodStatus { get; set; }

        public string Status { get; set; }

        public DateTime DhCriacao { get; set; }

        public int CriacaoCodUsuario { get; set; }

        public string UsuarioSolicitante { get; set; }

        public DateTime? DhFinalizada { get; set; }

        public int? FinalizadaCodUsuario { get; set; }

        public string UsuarioFinalizou { get; set; }

        public string ObservacaoOperador { get; set; }

        public string ObservacaoTecnica { get; set; }

        public bool HouveTrocaProduto { get; set; }

        public DateTime DhPrevisaoTermino { get; set; }

        public DateTime? DhCancelada { get; set; }

        public int? CanceladaCodUsuario { get; set; }

        public string UsuarioCancelou { get; set; }

        public string MotivoCancelamento { get; set; }

        public Produto produto = new Produto();

        public Cliente cliente = new Cliente();
    }
}
