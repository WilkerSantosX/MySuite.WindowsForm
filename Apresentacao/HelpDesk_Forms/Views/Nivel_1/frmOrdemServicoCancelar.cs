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
using Models;

namespace HelpDesk_Forms.Views.Nivel_1
{
    public partial class frmOrdemServicoCancelar : Form
    {
        public frmOrdemServicoCancelar()
        {
            InitializeComponent();
        }

        HelpdeskNegocio camadaNegocio = new HelpdeskNegocio();

        private void btnCloseForm_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnPesquisarOrdemServico_Click(object sender, EventArgs e)
        {
            if (txtSearchOrdemServico.Text != "")
            {
                DataTable ordemServico = new DataTable();

                ordemServico = camadaNegocio.OrdemServicoTableObterPorID(Convert.ToInt32(txtSearchOrdemServico.Text));

                dataGridOrdemServicoCancelar.DataSource = ordemServico;
                

            }
            else
            {
                MessageBox.Show("É necessário informar o Código da Ordem de Serviço", "Atenção!");
            }
        }

        private void btnCancelarOrdemServico_Click(object sender, EventArgs e)
        {
            if (txtMotivoCancelamento.Text != "" && txtSearchOrdemServico.Text != "")
            {
                OrdemServico ordemServico = new OrdemServico();
                ordemServico.CodOrdemServico = Convert.ToInt32(txtSearchOrdemServico.Text);
                ordemServico.DhCancelada = DateTime.Now;
                ordemServico.CanceladaCodUsuario = 1;
                ordemServico.MotivoCancelamento = txtMotivoCancelamento.Text;

                string retorno = camadaNegocio.OrdemServicoCancelar(ordemServico);

                MessageBox.Show(retorno, "CANCELADO!");

            }
            else
            {
                MessageBox.Show("É necessário informar o motivo de cancelamento da Ordem de Serviço", "Atenção!");
            }
        }
    }
}
