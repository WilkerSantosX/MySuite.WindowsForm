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

namespace HelpDesk_Forms.Views.Gestao
{
    public partial class FrmProduto : Form
    {
        public FrmProduto()
        {
            InitializeComponent();
        }

        HelpdeskNegocio camadaNegocio = new HelpdeskNegocio();

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void btnSairForm_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnInserirProduto_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtNomeProduto.Text))
                MessageBox.Show("É necessário informar o nome do Produto","ATENÇÃO");

            Produto produto = new Produto();
            produto.NomeProduto = txtNomeProduto.Text;
            produto.Ativo = true;

            string retorno = camadaNegocio.ProdutoInserir(produto);

            MessageBox.Show(retorno, "Sucesso");

            dataGridViewProduto.DataSource = camadaNegocio.ProdutoObterTodos();

        }

        private void FrmProduto_Load(object sender, EventArgs e)
        {
            dataGridViewProduto.DataSource = camadaNegocio.ProdutoObterTodos();
            dataGridViewProdutoInativo.DataSource = camadaNegocio.ProdutoObterInativos();
        }

        private void btnInativarProduto_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtNomeProdutoInativar.Text))
                MessageBox.Show("É necessário informar o código do Produto", "ATENÇÃO");

            Produto produto = new Produto();
            produto.CodProduto = Convert.ToInt32(txtNomeProdutoInativar.Text);
            produto.Ativo = false;

            string retorno = camadaNegocio.ProdutoInativar(produto);

            MessageBox.Show(retorno, "Sucesso");

            dataGridViewProdutoInativo.DataSource = camadaNegocio.ProdutoObterInativos();
            dataGridViewProduto.DataSource = camadaNegocio.ProdutoObterTodos();
        }
    }
}
