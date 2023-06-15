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
    public partial class frmUsuario : Form
    {
        public frmUsuario()
        {
            InitializeComponent();
        }

        HelpdeskNegocio camadaNegocio = new HelpdeskNegocio();
        PerfilCollection perfilCollection = new PerfilCollection();
        SetorCollection setorCollection = new SetorCollection();

        private void btnSairForm_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void frmUsuario_Load(object sender, EventArgs e)
        {
            List<string> perfil = new List<string>();
            perfilCollection = camadaNegocio.UsuarioTipoPerfilbterTodos();

            foreach (var item in perfilCollection)
            {
                perfil.Add(item.TipoPerfil);
            }

            combo_perfil.DataSource = perfil;

            List<string> setor = new List<string>();
            setorCollection = camadaNegocio.SetorbterTodos();

            foreach (var item in setorCollection)
            {
                setor.Add(item.Departamento);
            }

            combo_setor.DataSource = setor;

            dataGridViewUsuarios.DataSource = camadaNegocio.UsuarioObterTodos();

        }

        private void btnInserirCliente_Click(object sender, EventArgs e)
        {
            if (txtNome.Text != "" && txtEmail.Text != "" && txtLogin.Text != "" && txtSenha.Text != "")
            {
                Usuario usuario = new Usuario();

                usuario.Nome = txtNome.Text;
                usuario.Email = txtEmail.Text;
                usuario.Login = txtLogin.Text;
                usuario.Senha = txtSenha.Text;

                Perfil codPerfil = perfilCollection.Where(x => x.TipoPerfil == combo_perfil.Text.TrimEnd()).First();
                usuario.CodPerfil = codPerfil.CodPerfil;

                Setor codSetor = setorCollection.Where(x => x.Departamento == combo_setor.Text.TrimEnd()).First();
                usuario.CodSetor = codSetor.CodSetor;
                usuario.Ativo = true;

                string retorno = camadaNegocio.UsuarioInserir(usuario);

                MessageBox.Show(retorno, "Sucesso");

                dataGridViewUsuarios.DataSource = camadaNegocio.UsuarioObterTodos();
            }
            else
            {
                MessageBox.Show("É necessário informar todos os campos para o cadastro do usuário!", "Atenção");
            }
        }

        private void btnInativarUsuario_Click(object sender, EventArgs e)
        {
            if (txtSearchLogin.Text != "")
            {
                Usuario user = camadaNegocio.UsuarioObterPorLogin(txtSearchLogin.Text);

                if (user.CodUsuario > 0)
                {
                    DialogResult Dialogo = MessageBox.Show("Voce deseja realmente inativar o login: " + user.Login.ToUpper() + " ?",
                    "ATENÇÃO", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Exclamation);

                    if (Dialogo == DialogResult.Yes)
                    {
                        user.Ativo = false;
                        string retorno = camadaNegocio.UsuarioCancelar(user);

                        MessageBox.Show(retorno, "Sucesso");

                        dataGridViewUsuarios.DataSource = camadaNegocio.UsuarioObterTodos();
                    }
                }
                else
                {
                    MessageBox.Show("Login não encontrado e/ou já desativado!", "Aviso");
                }
            }
        }
    }
}
