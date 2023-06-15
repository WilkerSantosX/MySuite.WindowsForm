using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using HelpDesk_Forms.Views.Nivel_1;
using HelpDesk_Forms.Views.Nivel_2;
using Models;
using HelpdeskService;

namespace HelpDesk_Forms
{
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
        }

        HelpdeskNegocio classeDeNegocio = new HelpdeskNegocio();

        public int codUsuario = 0;
        public string nomeUser = String.Empty; 
        public int qtdAcesso = 0;
        public DateTime? dataAcesso;

        private void btnAcessar_Click(object sender, EventArgs e)
        {
            if (txtUsuario.Text != "" || txtSenha.Text != "")
            {
                Usuario user = new Usuario
                {
                    Login = Convert.ToString(txtUsuario.Text),
                    Senha = Convert.ToString(txtSenha.Text)
                };

                Usuario userAutenticado = new Usuario();

                userAutenticado = classeDeNegocio.VerificaLogin(user);

                codUsuario = userAutenticado.CodUsuario;
                nomeUser = userAutenticado.Nome;
                qtdAcesso = userAutenticado.QtdAcesso;
                dataAcesso = userAutenticado.DhAcesso;

                switch (userAutenticado.CodPerfil)
                {
                    case 1:
                        Views.Nivel_1.frmIndex index = new Views.Nivel_1.frmIndex(this);
                        index.Show();
                        Hide();
                        break;
                    case 2:
                        Views.Nivel_2.frmIndex nivel = new Views.Nivel_2.frmIndex(this);
                        nivel.Show();
                        Hide();
                        break;
                    case 3:
                        Views.Gestao.frmIndex adm = new Views.Gestao.frmIndex(this);
                        adm.Show();
                        Hide();
                        break;
                    default:
                        MessageBox.Show("Usuário e/ou Senha estão incorretos!", "Atenção!");
                        break;
                }
            }
            else
            {
                MessageBox.Show("Informar Usuário e Senha!", "Atenção!");
            }
        }

        private void frmLogin_Load(object sender, EventArgs e)
        {

        }
    }
}
