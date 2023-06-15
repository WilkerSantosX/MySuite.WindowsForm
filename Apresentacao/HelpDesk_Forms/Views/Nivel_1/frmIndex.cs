using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HelpDesk_Forms.Views.Nivel_1
{
    public partial class frmIndex : Form
    {
        frmLogin index = new frmLogin();

        public frmIndex(frmLogin login)
        {
            InitializeComponent();
            index = login;
        }

        private void frmIndex_Load(object sender, EventArgs e)
        {
            labelUsuario.Text = index.nomeUser;
            labelCountAcesso.Text = "Este é o seu " + index.qtdAcesso + "º acesso ao sistema!";
            labelDataAcesso.Text = Convert.ToString(index.dataAcesso);
        }

        private void btnOrdemServico_Grid_Click(object sender, EventArgs e)
        {
            frmOrdemServico OrdemServicoGrid = new frmOrdemServico(index);
            OrdemServicoGrid.Show();
        }

        private void btnClientes_Grid_Click(object sender, EventArgs e)
        {
            frmCliente ClientesGrid = new frmCliente();
            ClientesGrid.Show();
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            DialogResult Dialogo = MessageBox.Show("Voce deseja realmente sair do sistema?",
              "ATENÇÃO", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Exclamation);

            if (Dialogo == DialogResult.Yes)
            {
                Application.Exit();
            }
        }
    }
}
