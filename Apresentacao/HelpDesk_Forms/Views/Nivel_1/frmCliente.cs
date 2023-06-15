using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using HelpdeskService;

namespace HelpDesk_Forms.Views.Nivel_1
{
    public partial class frmCliente : Form
    {
        public frmCliente()
        {
            InitializeComponent();
        }

        HelpdeskNegocio camadaNegocio = new HelpdeskNegocio();

        private void btnCadastrarCliente_Click(object sender, EventArgs e)
        {
            frmClienteCriar clienteInserir = new frmClienteCriar();
            clienteInserir.Show();
        }

        private void btnClienteEditar_Click(object sender, EventArgs e)
        {
            frmClienteEditar clienteEditar = new frmClienteEditar();
            clienteEditar.Show();
        }

        private void btnCloseForm_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void frmCliente_Load(object sender, EventArgs e)
        {
            var retornoTabela = camadaNegocio.ClienteDataTableObterTodos();

            txtCount.Text = Convert.ToString(retornoTabela.Rows.Count);

            dataGridViewClientesCadastrados.DataSource = retornoTabela;
        }
    }
}
