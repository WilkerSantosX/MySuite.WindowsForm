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
    public partial class frmOrdemServicoInserir : Form
    {
        frmLogin index = new frmLogin();

        public frmOrdemServicoInserir(frmLogin login)
        {
            InitializeComponent();
            index = login;
        }

        HelpdeskNegocio classeDeNegocio = new HelpdeskNegocio();

        private void btnCloseForm_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void frmOrdemServicoInserir_Load(object sender, EventArgs e)
        {
            UFCollection comboUF = new UFCollection();

            comboUF = classeDeNegocio.ObterUF();

            List<string> uf = new List<string>();

            foreach (var item in comboUF)
            {
                uf.Add(item.Sigla);
            }

            combo_UF.DataSource = uf;

            ProdutoCollection comboCategoria = new ProdutoCollection();

            comboCategoria = classeDeNegocio.ProdutoObterTodos();

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

            comboCidade = classeDeNegocio.CidadesObterTodosPorUF(ufSelecionado);

            List<string> cidade = new List<string>();

            foreach (var item in comboCidade)
            {
                cidade.Add(item.NomeCidade);
            }

            combo_Cidade.DataSource = cidade;
        }

        private void combo_Setor_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnBuscarCliente_Click(object sender, EventArgs e)
        {
            if (txtBuscaCPF.Text != "")
            {
                Cliente cliente = new Cliente();

                cliente = classeDeNegocio.ClienteObterPorCPF(txtBuscaCPF.Text);

                if (cliente.CodCliente > 0)
                {
                    txtNomeCliente.Text = cliente.Nome;
                    txtCelular.Text = cliente.Telefone;
                    txtEmail.Text = cliente.Email;
                    txtEndereco.Text = cliente.Endereco;
                    txtBairro.Text = cliente.Bairro;
                    txtNumero.Text = cliente.Numero;
                    combo_UF.Text = cliente.UF;
                    combo_Cidade.Text = cliente.Cidade;

                }
                else
                {
                    MessageBox.Show("Cliente não localizado na base! Para continuar é necessário cadastrá-lo. Deseja cadastrar?", "CLIENTE NÃO CADASTRADO");

                    DialogResult Dialogo = MessageBox.Show("Cliente não localizado na base! Para continuar é necessário cadastrá-lo. Deseja cadastrar?",
                    "CLIENTE NÃO CADASTRADO", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Exclamation);

                    if (Dialogo == DialogResult.Yes)
                    {
                        frmClienteCriar clienteInserir = new frmClienteCriar();
                        clienteInserir.Show();
                    }
                }

            }
            else
            {
                MessageBox.Show("É necessário informar o CPF para consulta!", "ATENÇÃO");
            }
        }

        private void btnOrdemServicoInserir_Click(object sender, EventArgs e)
        {
            OrdemServico newOrdemServico = new OrdemServico();
            Produto produto = new Produto();
            Cliente cliente = new Cliente();
            string codOrdemServico = String.Empty;

            //Pegar o cliente inserido 
            cliente = classeDeNegocio.ClienteObterPorCPF(txtBuscaCPF.Text);
            newOrdemServico.cliente.CodCliente = cliente.CodCliente;

            //Pegar a categoria inserida
            produto = classeDeNegocio.ProdutoObterPorNome(combo_Categoria.Text);
            newOrdemServico.produto.CodProduto = produto.CodProduto;

            newOrdemServico.Assunto = txtAssunto.Text;
            newOrdemServico.Descricao = txtSolicitacaoCliente.Text;

            newOrdemServico.ObservacaoTecnica = txtProcedimentoRealizado.Text;

            if (!checkOrdemServicoResolvido.Checked)
            {
                //Em andamento
                newOrdemServico.CodStatus = 1;
            }
            else
            {
                //Finalizado
                newOrdemServico.CodStatus = 2;
            }

            newOrdemServico.DhCriacao = DateTime.Now;
            newOrdemServico.CriacaoCodUsuario = index.codUsuario;

            newOrdemServico.DhPrevisaoTermino = Convert.ToDateTime(dateTimePickerPrevisaoTermino.Text);

            codOrdemServico = classeDeNegocio.OrdemServicoInserir(newOrdemServico);

            MessageBox.Show("Ordem de Serviço inserido com sucesso! Código Nº: " + codOrdemServico , "Sucesso");
        }
    }
}
