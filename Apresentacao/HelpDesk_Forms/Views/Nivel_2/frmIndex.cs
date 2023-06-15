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

namespace HelpDesk_Forms.Views.Nivel_2
{
    public partial class frmIndex : Form
    {
        frmLogin index = new frmLogin();
        HelpdeskNegocio camadaNegocio = new HelpdeskNegocio();

        string codOs = String.Empty;
        int codUsuarioLogado = 0;

        public frmIndex(frmLogin login)
        {
            InitializeComponent();
            index = login;
        }

        private void btnFinalizarOrdemServico_Click(object sender, EventArgs e)
        {
            if (txtSearchOrdemServico.Text != "")
            {
                codOs = txtSearchOrdemServico.Text;

                OrdemServico ordemServico = camadaNegocio.OrdemServicoObterPorID(Convert.ToInt32(codOs));

                if (ordemServico.CodOrdemServico > 0)
                {
                    codUsuarioLogado = index.codUsuario;

                    frmOrdemServicoFinalizar ordemServicoFinalizar = new frmOrdemServicoFinalizar(codOs, ordemServico, codUsuarioLogado);
                    ordemServicoFinalizar.Show();
                }
                else
                {
                    MessageBox.Show("Verifique o código da Ordem de Serviço", "Não Localizado");
                }
            }
            else
            {
                MessageBox.Show("É necessário informar o código da Ordem de Serviço", "Atenção");
            }            
        }

        private void btnMenuSair_Click(object sender, EventArgs e)
        {
            DialogResult Dialogo = MessageBox.Show("Voce deseja realmente sair do sistema?",
              "ATENÇÃO", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Exclamation);

            if (Dialogo == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void frmIndex_Load(object sender, EventArgs e)
        {
            labelUsuario.Text = index.nomeUser;
            labelCountAcesso.Text = "Este é o seu " + index.qtdAcesso + "º acesso ao sistema!";
            labelDataAcesso.Text = Convert.ToString(index.dataAcesso);

            var retornoTabela = camadaNegocio.OrdemServicoObterTodos();

            txtCount.Text = Convert.ToString(retornoTabela.Rows.Count);

            dataGridViewOrdemServico.DataSource = retornoTabela;
        }

        //Atualiza o grid a cada 05 segundos
        private void timer1_Tick(object sender, EventArgs e)
        {
            var retornoTabela = camadaNegocio.OrdemServicoObterTodos();
            txtCount.Text = Convert.ToString(retornoTabela.Rows.Count);
            dataGridViewOrdemServico.DataSource = retornoTabela;
        }
    }
}
