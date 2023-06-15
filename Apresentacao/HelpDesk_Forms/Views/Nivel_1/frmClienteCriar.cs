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
    public partial class frmClienteCriar : Form
    {
        public frmClienteCriar()
        {
            InitializeComponent();
        }

        HelpdeskNegocio classeDeNegocio = new HelpdeskNegocio();

        private void btnCloseForm_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void frmClienteCriar_Load(object sender, EventArgs e)
        {
            UFCollection comboUF = new UFCollection();

            comboUF = classeDeNegocio.ObterUF();

            List<string> uf = new List<string>();

            foreach (var item in comboUF)
            {
                uf.Add(item.Sigla);
            }

            combo_UF.DataSource = uf;
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

            combo_cidade.DataSource = cidade;
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            if (txtCpf.Text != "" && txtCliente.Text != "" && txtTelefone.Text != "" && txtEmail.Text != "" 
                && txtEndereco.Text != "" && txtNumero.Text != "" && txtBairro.Text != "" && combo_cidade.Text != "" && combo_UF.Text != "")     
            {
                Cliente cliente = new Cliente();

                cliente.CPF = txtCpf.Text;
                cliente.Nome = txtCliente.Text;
                cliente.Telefone = txtTelefone.Text;
                cliente.Email = txtEmail.Text;

                cliente.Endereco = txtEndereco.Text;
                cliente.Numero = txtNumero.Text;
                cliente.Bairro = txtBairro.Text;

                cliente.CodCidade = classeDeNegocio.CidadeObterPorNomeEstado(Convert.ToString(combo_cidade.SelectedValue).TrimEnd(), Convert.ToString(combo_UF.SelectedValue).TrimEnd());

                string retorno = classeDeNegocio.ClienteInserir(cliente);

                MessageBox.Show(retorno, "Sucesso");
            }
            else
            {
                MessageBox.Show("É necessário preencher todos os campos!", "Atenção");
            }
        }
    }
}
