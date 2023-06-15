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
    public partial class frmOrdemServicoFinalizar : Form
    {
        HelpdeskNegocio camadaNegocio = new HelpdeskNegocio();
        OrdemServico ordemServico = new OrdemServico();
        string codOrdemServico = String.Empty;
        int codUsuario = 0;

        public frmOrdemServicoFinalizar(string index, OrdemServico os, int codUsuarioLogado)
        {
            InitializeComponent();
            codOrdemServico = index;
            ordemServico = os;
            codUsuario = codUsuarioLogado;
        }

        private void btnCloseForm_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void frmOrdemServicoFinalizar_Load(object sender, EventArgs e)
        {
            labelCodigoOS.Text = codOrdemServico;
            combo_produto.Text = "NÃO";

            txtCliente.Text = ordemServico.cliente.CPF + " - " + ordemServico.cliente.Nome;
            txtCliente.Enabled = false;
            txtTelefone.Text = ordemServico.cliente.Telefone;
            txtTelefone.Enabled = false;
            txtEmail.Text = ordemServico.cliente.Email;
            txtEmail.Enabled = false;
            txtEndereco.Text = ordemServico.cliente.Endereco;
            txtEndereco.Enabled = false;
            txtNumero.Text = ordemServico.cliente.Numero;
            txtNumero.Enabled = false;
            txtBairro.Text = ordemServico.cliente.Bairro;
            txtBairro.Enabled = false;
            txtUF.Text = ordemServico.cliente.UF;
            txtUF.Enabled = false;
            txtCidade.Text = ordemServico.cliente.Cidade;
            txtCidade.Enabled = false;

            txtAssunto.Text = ordemServico.Assunto;
            txtAssunto.Enabled = false;
            txtSetor.Text = "SUPORTE NIVEL 2";
            txtSetor.Enabled = false;
            txtCategoria.Text = ordemServico.produto.NomeProduto;
            txtCategoria.Enabled = false;
            txtDataConclusao.Text = Convert.ToString(ordemServico.DhPrevisaoTermino);
            txtDataConclusao.Enabled = false;

            txtSolicitacao.Text = ordemServico.Descricao;
            txtSolicitacao.Enabled = false;
            txtAtendimento.Text = ordemServico.ObservacaoOperador;
            txtAtendimento.Enabled = false;

        }

        private void btnFinalizarOrdemServico_Click(object sender, EventArgs e)
        {
            if (combo_produto.Text != "" && txtObservacaoTecnica.Text != "")
            {
                if (combo_produto.Text.TrimEnd() == "SIM")
                    ordemServico.HouveTrocaProduto = true;
                else
                    ordemServico.HouveTrocaProduto = false;

                ordemServico.ObservacaoTecnica = txtObservacaoTecnica.Text;

                ordemServico.CodStatus = 2;
                ordemServico.DhFinalizada = DateTime.Now;
                ordemServico.FinalizadaCodUsuario = codUsuario;

                string retorno = camadaNegocio.OrdemServicoFinalizar(ordemServico);

                MessageBox.Show(retorno, "Sucesso");
            }
            else
            {
                MessageBox.Show("É necessário informar a troca de produto e a descrição do atendimento!", "Atenção");
            }
        }
    }
}
