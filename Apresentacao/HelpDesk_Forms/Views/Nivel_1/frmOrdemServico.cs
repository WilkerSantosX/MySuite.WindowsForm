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
    public partial class frmOrdemServico : Form
    {
        frmLogin index = new frmLogin();
        HelpdeskNegocio camadaNegocio = new HelpdeskNegocio();
         
        public frmOrdemServico(frmLogin login)
        {
            InitializeComponent();
            index = login;
        }

        private void btnSairForm_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnCriarOrdemServico_Click(object sender, EventArgs e)
        {
            frmOrdemServicoInserir ordemServicoInserir = new frmOrdemServicoInserir(index);
            ordemServicoInserir.Show();
        }

        private void btnEditarOrdemServico_Click(object sender, EventArgs e)
        {
            frmOrdemServicoEditar ordemServicoEditar = new frmOrdemServicoEditar();
            ordemServicoEditar.Show();
        }

        private void btnCancelarOrdemServico_Click(object sender, EventArgs e)
        {
            frmOrdemServicoCancelar ordemServicoCancelar = new frmOrdemServicoCancelar();
            ordemServicoCancelar.Show();
        }

        private void frmOrdemServico_Load(object sender, EventArgs e)
        {
            var retornoTabela = camadaNegocio.OrdemServicoObterAbertos();
     
            txtCount.Text = Convert.ToString(retornoTabela.Rows.Count);

            dataGridViewOrdemServicoAbertos.DataSource = retornoTabela;
        }

        private void dataGridViewOrdemServicoAbertos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
