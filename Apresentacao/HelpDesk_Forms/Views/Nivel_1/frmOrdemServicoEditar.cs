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
    public partial class frmOrdemServicoEditar : Form
    {
        public frmOrdemServicoEditar()
        {
            InitializeComponent();
        }

        HelpdeskNegocio camadaNegocio = new HelpdeskNegocio();
        OrdemServico ordemServico = new OrdemServico();

        private void btnBuscarOrdemServico_Click(object sender, EventArgs e)
        {
            if (txtOrdemServicoSearch.Text != "")
            {
                ordemServico = camadaNegocio.OrdemServicoObterPorID(Convert.ToInt32(txtOrdemServicoSearch.Text));

                txtCodigoOrdemServico.Text = Convert.ToString(ordemServico.CodOrdemServico);
                txtCodigoOrdemServico.Enabled = false;

                txtCliente.Text = ordemServico.cliente.CPF + " - " + ordemServico.cliente.Nome;
                txtCliente.Enabled = false;

                txtTelefone.Text = ordemServico.cliente.Telefone;
                txtEmail.Text = ordemServico.cliente.Email;
                txtEndereco.Text = ordemServico.cliente.Endereco;
                txtNumero.Text = ordemServico.cliente.Numero;
                txtBairro.Text = ordemServico.cliente.Bairro;

                CidadeUF cidadeUF = camadaNegocio.CidadeObterPorID(ordemServico.cliente.CodCidade);

                combo_UF.Text = cidadeUF.Sigla;
                combo_Cidade.Text = cidadeUF.NomeCidade;

                txtAssunto.Text = ordemServico.Assunto;
                combo_Setor.Text = "SUPORTE NIVEL 2";
                combo_Categoria.Text = ordemServico.produto.NomeProduto;

                dateDhPrevisao.Text = Convert.ToString(ordemServico.DhPrevisaoTermino);

                txt_SolicitacaoCliente.Text = ordemServico.Descricao;
                txtAtendimentoRealizado.Text = ordemServico.ObservacaoOperador; 

                this.panel_Visible.Size = new System.Drawing.Size(0, 0);
            }
            else
            {
                MessageBox.Show("Uma ordem de serviço deve ser preenchido!", "Atenção");
            }
        }

        private void btnCloseForm_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void frmOrdemServicoEditar_Load(object sender, EventArgs e)
        {
            UFCollection comboUF = new UFCollection();

            comboUF = camadaNegocio.ObterUF();

            List<string> uf = new List<string>();

            foreach (var item in comboUF)
            {
                uf.Add(item.Sigla);
            }

            combo_UF.DataSource = uf;

            ProdutoCollection comboCategoria = new ProdutoCollection();

            comboCategoria = camadaNegocio.ProdutoObterTodos();

            List<string> categoria = new List<string>();

            foreach (var item in comboCategoria)
            {
                categoria.Add(item.NomeProduto);
            }

            combo_Categoria.DataSource = categoria;

        }

        private void combo_UF_SelectedIndexChanged(object sender, EventArgs e)
        {
            string ufSelecionado = Convert.ToString(combo_UF.SelectedValue).TrimEnd();

            CidadeUFCollection comboCidade = new CidadeUFCollection();

            comboCidade = camadaNegocio.CidadesObterTodosPorUF(ufSelecionado);

            List<string> cidade = new List<string>();

            foreach (var item in comboCidade)
            {
                cidade.Add(item.NomeCidade);
            }

            combo_Cidade.DataSource = cidade;
        }

        private void btnOrdemServicoSalvar_Click(object sender, EventArgs e)
        {
            if (ordemServico.CodOrdemServico > 0)
            {
                //Populando informações ao cliente
                ordemServico.cliente.Telefone = txtTelefone.Text;
                ordemServico.cliente.Endereco = txtEndereco.Text;
                ordemServico.cliente.Numero = txtNumero.Text;
                ordemServico.cliente.Bairro = txtBairro.Text;
                ordemServico.cliente.CodCidade = camadaNegocio.CidadeObterPorNomeEstado(combo_Cidade.Text.TrimEnd(), combo_UF.Text.TrimEnd());

                //Atualizando dados do cliente
                camadaNegocio.ClienteEditar(ordemServico);

                //Populando informações da Ordem de Serviço
                ordemServico.Assunto = txtAssunto.Text;
                ordemServico.Descricao = txt_SolicitacaoCliente.Text;
                ordemServico.ObservacaoOperador = txtAtendimentoRealizado.Text;
                ordemServico.DhPrevisaoTermino = Convert.ToDateTime(dateDhPrevisao.Text);
                ordemServico.produto.CodProduto = camadaNegocio.ProdutoObterPorNome(Convert.ToString(combo_Categoria.Text)).CodProduto;

                if (!checkOrdemServicoResolvido.Checked)
                {
                    //Em andamento
                    ordemServico.CodStatus = 1;
                }
                else
                {
                    //Finalizado
                    ordemServico.CodStatus = 2;
                }

                string retorno = camadaNegocio.OrdemServicoEditar(ordemServico);

                MessageBox.Show(retorno, "Sucesso");
            }
        }
    }
}
