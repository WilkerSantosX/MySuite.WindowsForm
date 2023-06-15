using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    public class Usuario
    {
        public int CodUsuario { get; set; }

        public string Nome { get; set; }

        public string Email { get; set; }

        public string Login { get; set; }

        public string Senha { get; set; }

        public int CodPerfil { get; set; }

        public int CodSetor { get; set; }

        public bool Ativo { get; set; }
		
		public int QtdAcesso { get; set; }

        public DateTime? DhAcesso { get; set; }
    }
}
