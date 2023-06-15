namespace HelpDesk_Forms.Views.Gestao
{
    partial class frmUsuario
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmUsuario));
            this.dataGridViewUsuarios = new System.Windows.Forms.DataGridView();
            this.panel4 = new System.Windows.Forms.Panel();
            this.label18 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.btnSairForm = new System.Windows.Forms.Button();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtLogin = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtSenha = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.combo_perfil = new System.Windows.Forms.ComboBox();
            this.combo_setor = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.txtSearchLogin = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.btnInserirCliente = new System.Windows.Forms.Button();
            this.btnInativarUsuario = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewUsuarios)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewUsuarios
            // 
            this.dataGridViewUsuarios.AllowUserToAddRows = false;
            this.dataGridViewUsuarios.AllowUserToDeleteRows = false;
            this.dataGridViewUsuarios.AllowUserToOrderColumns = true;
            this.dataGridViewUsuarios.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewUsuarios.Location = new System.Drawing.Point(-4, 440);
            this.dataGridViewUsuarios.Name = "dataGridViewUsuarios";
            this.dataGridViewUsuarios.ReadOnly = true;
            this.dataGridViewUsuarios.Size = new System.Drawing.Size(1359, 291);
            this.dataGridViewUsuarios.TabIndex = 66;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.panel4.Location = new System.Drawing.Point(-6, 94);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(1363, 10);
            this.panel4.TabIndex = 67;
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.BackColor = System.Drawing.Color.White;
            this.label18.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.25F);
            this.label18.ForeColor = System.Drawing.Color.Black;
            this.label18.Location = new System.Drawing.Point(40, 34);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(233, 22);
            this.label18.TabIndex = 68;
            this.label18.Text = "Gerenciamento de Usuários";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.White;
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.Location = new System.Drawing.Point(1239, 68);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(40, 13);
            this.label5.TabIndex = 77;
            this.label5.Text = "Fechar";
            // 
            // btnSairForm
            // 
            this.btnSairForm.BackColor = System.Drawing.Color.White;
            this.btnSairForm.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnSairForm.BackgroundImage")));
            this.btnSairForm.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnSairForm.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnSairForm.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnSairForm.Location = new System.Drawing.Point(1238, 20);
            this.btnSairForm.Name = "btnSairForm";
            this.btnSairForm.Size = new System.Drawing.Size(39, 35);
            this.btnSairForm.TabIndex = 78;
            this.btnSairForm.UseVisualStyleBackColor = false;
            this.btnSairForm.Click += new System.EventHandler(this.btnSairForm_Click);
            // 
            // txtNome
            // 
            this.txtNome.BackColor = System.Drawing.SystemColors.Menu;
            this.txtNome.Location = new System.Drawing.Point(45, 189);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(209, 20);
            this.txtNome.TabIndex = 142;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(42, 163);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(42, 13);
            this.label2.TabIndex = 141;
            this.label2.Text = "NOME:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.White;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.25F);
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(41, 124);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(89, 22);
            this.label1.TabIndex = 143;
            this.label1.Text = "Cadastrar";
            // 
            // txtEmail
            // 
            this.txtEmail.BackColor = System.Drawing.SystemColors.Menu;
            this.txtEmail.Location = new System.Drawing.Point(287, 189);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(224, 20);
            this.txtEmail.TabIndex = 145;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(284, 163);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(42, 13);
            this.label3.TabIndex = 144;
            this.label3.Text = "EMAIL:";
            // 
            // txtLogin
            // 
            this.txtLogin.BackColor = System.Drawing.SystemColors.Menu;
            this.txtLogin.Location = new System.Drawing.Point(549, 189);
            this.txtLogin.Name = "txtLogin";
            this.txtLogin.Size = new System.Drawing.Size(145, 20);
            this.txtLogin.TabIndex = 147;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(546, 163);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(43, 13);
            this.label4.TabIndex = 146;
            this.label4.Text = "LOGIN:";
            // 
            // txtSenha
            // 
            this.txtSenha.BackColor = System.Drawing.SystemColors.Menu;
            this.txtSenha.Location = new System.Drawing.Point(727, 189);
            this.txtSenha.Name = "txtSenha";
            this.txtSenha.PasswordChar = '*';
            this.txtSenha.Size = new System.Drawing.Size(145, 20);
            this.txtSenha.TabIndex = 149;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(724, 163);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(47, 13);
            this.label6.TabIndex = 148;
            this.label6.Text = "SENHA:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(905, 163);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(47, 13);
            this.label7.TabIndex = 150;
            this.label7.Text = "PERFIL:";
            // 
            // combo_perfil
            // 
            this.combo_perfil.FormattingEnabled = true;
            this.combo_perfil.Location = new System.Drawing.Point(908, 188);
            this.combo_perfil.Name = "combo_perfil";
            this.combo_perfil.Size = new System.Drawing.Size(179, 21);
            this.combo_perfil.TabIndex = 151;
            // 
            // combo_setor
            // 
            this.combo_setor.FormattingEnabled = true;
            this.combo_setor.Location = new System.Drawing.Point(1126, 187);
            this.combo_setor.Name = "combo_setor";
            this.combo_setor.Size = new System.Drawing.Size(179, 21);
            this.combo_setor.TabIndex = 153;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(1123, 162);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(47, 13);
            this.label8.TabIndex = 152;
            this.label8.Text = "SETOR:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.White;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.25F);
            this.label9.ForeColor = System.Drawing.Color.Black;
            this.label9.Location = new System.Drawing.Point(40, 306);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(68, 22);
            this.label9.TabIndex = 154;
            this.label9.Text = "Inativar";
            // 
            // txtSearchLogin
            // 
            this.txtSearchLogin.BackColor = System.Drawing.SystemColors.Menu;
            this.txtSearchLogin.Location = new System.Drawing.Point(99, 348);
            this.txtSearchLogin.Name = "txtSearchLogin";
            this.txtSearchLogin.Size = new System.Drawing.Size(145, 20);
            this.txtSearchLogin.TabIndex = 156;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(43, 351);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(43, 13);
            this.label10.TabIndex = 155;
            this.label10.Text = "LOGIN:";
            // 
            // btnInserirCliente
            // 
            this.btnInserirCliente.BackColor = System.Drawing.SystemColors.Control;
            this.btnInserirCliente.ForeColor = System.Drawing.Color.Black;
            this.btnInserirCliente.Location = new System.Drawing.Point(44, 233);
            this.btnInserirCliente.Name = "btnInserirCliente";
            this.btnInserirCliente.Size = new System.Drawing.Size(94, 23);
            this.btnInserirCliente.TabIndex = 157;
            this.btnInserirCliente.Text = "Inserir Usuario";
            this.btnInserirCliente.UseVisualStyleBackColor = false;
            this.btnInserirCliente.Click += new System.EventHandler(this.btnInserirCliente_Click);
            // 
            // btnInativarUsuario
            // 
            this.btnInativarUsuario.BackColor = System.Drawing.SystemColors.Control;
            this.btnInativarUsuario.ForeColor = System.Drawing.Color.Black;
            this.btnInativarUsuario.Location = new System.Drawing.Point(44, 389);
            this.btnInativarUsuario.Name = "btnInativarUsuario";
            this.btnInativarUsuario.Size = new System.Drawing.Size(94, 23);
            this.btnInativarUsuario.TabIndex = 158;
            this.btnInativarUsuario.Text = "Inativar Usuario";
            this.btnInativarUsuario.UseVisualStyleBackColor = false;
            this.btnInativarUsuario.Click += new System.EventHandler(this.btnInativarUsuario_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Black;
            this.panel1.Location = new System.Drawing.Point(1, 284);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1356, 1);
            this.panel1.TabIndex = 159;
            // 
            // frmUsuario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1350, 730);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnInativarUsuario);
            this.Controls.Add(this.btnInserirCliente);
            this.Controls.Add(this.txtSearchLogin);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.combo_setor);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.combo_perfil);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtSenha);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtLogin);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtNome);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.btnSairForm);
            this.Controls.Add(this.label18);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.dataGridViewUsuarios);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "frmUsuario";
            this.Text = "frmUsuario";
            this.Load += new System.EventHandler(this.frmUsuario_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewUsuarios)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewUsuarios;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnSairForm;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtLogin;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtSenha;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox combo_perfil;
        private System.Windows.Forms.ComboBox combo_setor;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtSearchLogin;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button btnInserirCliente;
        private System.Windows.Forms.Button btnInativarUsuario;
        private System.Windows.Forms.Panel panel1;
    }
}