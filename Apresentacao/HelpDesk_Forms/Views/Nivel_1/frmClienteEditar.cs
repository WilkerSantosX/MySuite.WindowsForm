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
    public partial class frmClienteEditar : Form
    {
        public frmClienteEditar()
        {
            InitializeComponent();
        }

        HelpdeskNegocio classeDeNegocio = new HelpdeskNegocio();

        private void btnBuscarCliente_Click(object sender, EventArgs e)
        {
            if (txtSearchCPF.Text != "")
            {
                Cliente cliente = classeDeNegocio.ClienteObterPorCPF(txtSearchCPF.Text);

                if (cliente.CodCliente > 0)
                {
                    txtCliente.Text = cliente.Nome;
                    txtTelefone.Text = cliente.Telefone;
                    txtEmail.Text = cliente.Email;

                    txtEndereco.Text = cliente.Endereco;
                    txtNumero.Text = cliente.Numero;
                    txtBairro.Text = cliente.Bairro;

                    combo_UF.Text = cliente.UF;
                    combo_Cidade.Text = cliente.Cidade;

                    this.panel_Visible.Size = new System.Drawing.Size(0, 0);
                }
                else
                {
                    MessageBox.Show("Cliente não localizado!", "Aviso");
                }
            }
            else
            {
                MessageBox.Show("É necessário informar um CPF!", "Atenção");
            }
        }

        private void btnCloseForm_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void frmClienteEditar_Load(object sender, EventArgs e)
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

            combo_Cidade.DataSource = cidade;
        }
    }
}
