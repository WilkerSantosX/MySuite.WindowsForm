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
    public partial class frmRelatorio : Form
    {
        public frmRelatorio()
        {
            InitializeComponent();
        }

        HelpdeskNegocio camadaNegocio = new HelpdeskNegocio();
        UsuarioCollection usuarioCollection = new UsuarioCollection();
        StatusCollection statusCollection = new StatusCollection();

        private void frmRelatorio_Load(object sender, EventArgs e)
        {
            statusCollection = camadaNegocio.StatusObterTodos();

            List<string> nomeStatus = new List<string>();
            nomeStatus.Add("TODOS");

            foreach (var item in statusCollection)
            {
                nomeStatus.Add(item.NomeStatus);
            }

            combo_Status.DataSource = nomeStatus;


            usuarioCollection = camadaNegocio.UsuarioObterLista();

            List<string> nomeUser = new List<string>();
            nomeUser.Add("Todos");

            foreach (var item in usuarioCollection)
            {
                nomeUser.Add(item.Nome);
            }

            combo_User.DataSource = nomeUser;
        }

        private void btnSairForm_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnPesquisar_Click(object sender, EventArgs e)
        {
            int codCliente = 0;
            Status status = new Status();
            Usuario user = new Usuario();

            if (txtCpfCliente.Text != "")
            {
                codCliente = camadaNegocio.ClienteObterPorCPF(txtCpfCliente.Text).CodCliente;
            }

            else if (combo_Status.Text.ToUpper() != "TODOS")
            {
                status = statusCollection.Where(x => x.NomeStatus == combo_Status.Text).First();
            }

            else if (combo_User.Text.ToUpper() != "TODOS")
            {
                user = usuarioCollection.Where(x => x.Nome == combo_User.Text).First();
            }

            dataGridViewRelatorio.DataSource  = camadaNegocio.OrdemServicoRelatorio(codCliente, status.CodStatus, user.CodUsuario);
        }
    }
}
