namespace HelpDesk_Forms.Views.Nivel_1
{
    partial class frmOrdemServicoInserir
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmOrdemServicoInserir));
            this.btnBuscarCliente = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.txtBuscaCPF = new System.Windows.Forms.TextBox();
            this.label17 = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.dateTimePickerPrevisaoTermino = new System.Windows.Forms.DateTimePicker();
            this.combo_Cidade = new System.Windows.Forms.ComboBox();
            this.combo_UF = new System.Windows.Forms.ComboBox();
            this.combo_Categoria = new System.Windows.Forms.ComboBox();
            this.combo_Setor = new System.Windows.Forms.ComboBox();
            this.checkOrdemServicoResolvido = new System.Windows.Forms.CheckBox();
            this.txtProcedimentoRealizado = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.btnOrdemServicoInserir = new System.Windows.Forms.Button();
            this.txtSolicitacaoCliente = new System.Windows.Forms.TextBox();
            this.txtAssunto = new System.Windows.Forms.TextBox();
            this.txtBairro = new System.Windows.Forms.TextBox();
            this.txtNumero = new System.Windows.Forms.TextBox();
            this.txtEndereco = new System.Windows.Forms.TextBox();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.txtCelular = new System.Windows.Forms.TextBox();
            this.txtNomeCliente = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.btnCloseForm = new System.Windows.Forms.Button();
            this.label23 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnBuscarCliente
            // 
            this.btnBuscarCliente.BackColor = System.Drawing.SystemColors.Control;
            this.btnBuscarCliente.ForeColor = System.Drawing.Color.Black;
            this.btnBuscarCliente.Location = new System.Drawing.Point(271, 87);
            this.btnBuscarCliente.Name = "btnBuscarCliente";
            this.btnBuscarCliente.Size = new System.Drawing.Size(75, 23);
            this.btnBuscarCliente.TabIndex = 117;
            this.btnBuscarCliente.Text = "Buscar";
            this.btnBuscarCliente.UseVisualStyleBackColor = false;
            this.btnBuscarCliente.Click += new System.EventHandler(this.btnBuscarCliente_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.White;
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(56, 92);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(30, 13);
            this.label2.TabIndex = 116;
            this.label2.Text = "CPF:";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.BackColor = System.Drawing.Color.White;
            this.label18.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.25F);
            this.label18.ForeColor = System.Drawing.Color.Black;
            this.label18.Location = new System.Drawing.Point(51, 19);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(279, 22);
            this.label18.TabIndex = 120;
            this.label18.Text = "Inserindo Nova Ordem de Serviço";
            // 
            // txtBuscaCPF
            // 
            this.txtBuscaCPF.BackColor = System.Drawing.Color.White;
            this.txtBuscaCPF.ForeColor = System.Drawing.Color.Black;
            this.txtBuscaCPF.Location = new System.Drawing.Point(101, 88);
            this.txtBuscaCPF.Name = "txtBuscaCPF";
            this.txtBuscaCPF.Size = new System.Drawing.Size(146, 20);
            this.txtBuscaCPF.TabIndex = 118;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.BackColor = System.Drawing.Color.White;
            this.label17.ForeColor = System.Drawing.Color.Black;
            this.label17.Location = new System.Drawing.Point(52, 56);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(195, 13);
            this.label17.TabIndex = 119;
            this.label17.Text = "LOCALIZAR CADASTRO DO CLIENTE";
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.panel4.Location = new System.Drawing.Point(-6, 126);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(1363, 10);
            this.panel4.TabIndex = 130;
            // 
            // dateTimePickerPrevisaoTermino
            // 
            this.dateTimePickerPrevisaoTermino.Location = new System.Drawing.Point(918, 352);
            this.dateTimePickerPrevisaoTermino.Name = "dateTimePickerPrevisaoTermino";
            this.dateTimePickerPrevisaoTermino.Size = new System.Drawing.Size(200, 20);
            this.dateTimePickerPrevisaoTermino.TabIndex = 161;
            // 
            // combo_Cidade
            // 
            this.combo_Cidade.FormattingEnabled = true;
            this.combo_Cidade.Location = new System.Drawing.Point(1071, 269);
            this.combo_Cidade.Name = "combo_Cidade";
            this.combo_Cidade.Size = new System.Drawing.Size(190, 21);
            this.combo_Cidade.TabIndex = 160;
            // 
            // combo_UF
            // 
            this.combo_UF.FormattingEnabled = true;
            this.combo_UF.Location = new System.Drawing.Point(965, 269);
            this.combo_UF.Name = "combo_UF";
            this.combo_UF.Size = new System.Drawing.Size(59, 21);
            this.combo_UF.TabIndex = 159;
            this.combo_UF.SelectedIndexChanged += new System.EventHandler(this.combo_UF_SelectedIndexChanged);
            // 
            // combo_Categoria
            // 
            this.combo_Categoria.FormattingEnabled = true;
            this.combo_Categoria.Location = new System.Drawing.Point(700, 352);
            this.combo_Categoria.Name = "combo_Categoria";
            this.combo_Categoria.Size = new System.Drawing.Size(164, 21);
            this.combo_Categoria.TabIndex = 158;
            // 
            // combo_Setor
            // 
            this.combo_Setor.FormattingEnabled = true;
            this.combo_Setor.Location = new System.Drawing.Point(485, 353);
            this.combo_Setor.Name = "combo_Setor";
            this.combo_Setor.Size = new System.Drawing.Size(164, 21);
            this.combo_Setor.TabIndex = 157;
            this.combo_Setor.Text = "SUPORTE NIVEL 2";
            this.combo_Setor.SelectedIndexChanged += new System.EventHandler(this.combo_Setor_SelectedIndexChanged);
            // 
            // checkOrdemServicoResolvido
            // 
            this.checkOrdemServicoResolvido.AutoSize = true;
            this.checkOrdemServicoResolvido.Location = new System.Drawing.Point(61, 653);
            this.checkOrdemServicoResolvido.Name = "checkOrdemServicoResolvido";
            this.checkOrdemServicoResolvido.Size = new System.Drawing.Size(73, 17);
            this.checkOrdemServicoResolvido.TabIndex = 156;
            this.checkOrdemServicoResolvido.Text = "Resolvido";
            this.checkOrdemServicoResolvido.UseVisualStyleBackColor = true;
            // 
            // txtProcedimentoRealizado
            // 
            this.txtProcedimentoRealizado.BackColor = System.Drawing.SystemColors.Menu;
            this.txtProcedimentoRealizado.Location = new System.Drawing.Point(59, 542);
            this.txtProcedimentoRealizado.Multiline = true;
            this.txtProcedimentoRealizado.Name = "txtProcedimentoRealizado";
            this.txtProcedimentoRealizado.Size = new System.Drawing.Size(1246, 83);
            this.txtProcedimentoRealizado.TabIndex = 155;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(57, 518);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(175, 13);
            this.label15.TabIndex = 154;
            this.label15.Text = "PROCEDIMENTOS REALIZADOS:";
            // 
            // btnOrdemServicoInserir
            // 
            this.btnOrdemServicoInserir.BackColor = System.Drawing.Color.White;
            this.btnOrdemServicoInserir.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnOrdemServicoInserir.BackgroundImage")));
            this.btnOrdemServicoInserir.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnOrdemServicoInserir.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnOrdemServicoInserir.ForeColor = System.Drawing.Color.White;
            this.btnOrdemServicoInserir.Location = new System.Drawing.Point(659, 659);
            this.btnOrdemServicoInserir.Name = "btnOrdemServicoInserir";
            this.btnOrdemServicoInserir.Size = new System.Drawing.Size(54, 52);
            this.btnOrdemServicoInserir.TabIndex = 144;
            this.btnOrdemServicoInserir.UseVisualStyleBackColor = false;
            this.btnOrdemServicoInserir.Click += new System.EventHandler(this.btnOrdemServicoInserir_Click);
            // 
            // txtSolicitacaoCliente
            // 
            this.txtSolicitacaoCliente.BackColor = System.Drawing.SystemColors.Menu;
            this.txtSolicitacaoCliente.Location = new System.Drawing.Point(56, 418);
            this.txtSolicitacaoCliente.Multiline = true;
            this.txtSolicitacaoCliente.Name = "txtSolicitacaoCliente";
            this.txtSolicitacaoCliente.Size = new System.Drawing.Size(1246, 83);
            this.txtSolicitacaoCliente.TabIndex = 152;
            // 
            // txtAssunto
            // 
            this.txtAssunto.BackColor = System.Drawing.SystemColors.Menu;
            this.txtAssunto.Location = new System.Drawing.Point(56, 355);
            this.txtAssunto.Multiline = true;
            this.txtAssunto.Name = "txtAssunto";
            this.txtAssunto.Size = new System.Drawing.Size(396, 20);
            this.txtAssunto.TabIndex = 151;
            // 
            // txtBairro
            // 
            this.txtBairro.BackColor = System.Drawing.SystemColors.Menu;
            this.txtBairro.Location = new System.Drawing.Point(705, 271);
            this.txtBairro.Name = "txtBairro";
            this.txtBairro.Size = new System.Drawing.Size(217, 20);
            this.txtBairro.TabIndex = 150;
            // 
            // txtNumero
            // 
            this.txtNumero.BackColor = System.Drawing.SystemColors.Menu;
            this.txtNumero.Location = new System.Drawing.Point(586, 271);
            this.txtNumero.Name = "txtNumero";
            this.txtNumero.Size = new System.Drawing.Size(63, 20);
            this.txtNumero.TabIndex = 149;
            // 
            // txtEndereco
            // 
            this.txtEndereco.BackColor = System.Drawing.SystemColors.Menu;
            this.txtEndereco.Location = new System.Drawing.Point(53, 271);
            this.txtEndereco.Name = "txtEndereco";
            this.txtEndereco.Size = new System.Drawing.Size(491, 20);
            this.txtEndereco.TabIndex = 148;
            // 
            // txtEmail
            // 
            this.txtEmail.BackColor = System.Drawing.SystemColors.Menu;
            this.txtEmail.Location = new System.Drawing.Point(746, 188);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(344, 20);
            this.txtEmail.TabIndex = 147;
            // 
            // txtCelular
            // 
            this.txtCelular.BackColor = System.Drawing.SystemColors.Menu;
            this.txtCelular.Location = new System.Drawing.Point(525, 188);
            this.txtCelular.Name = "txtCelular";
            this.txtCelular.Size = new System.Drawing.Size(146, 20);
            this.txtCelular.TabIndex = 146;
            // 
            // txtNomeCliente
            // 
            this.txtNomeCliente.BackColor = System.Drawing.SystemColors.Menu;
            this.txtNomeCliente.Location = new System.Drawing.Point(53, 188);
            this.txtNomeCliente.Name = "txtNomeCliente";
            this.txtNomeCliente.Size = new System.Drawing.Size(414, 20);
            this.txtNomeCliente.TabIndex = 145;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(54, 394);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(147, 13);
            this.label14.TabIndex = 143;
            this.label14.Text = "SOLICITACAO DO CLIENTE:";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(915, 322);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(96, 13);
            this.label13.TabIndex = 142;
            this.label13.Text = "DATA PREVISAO:";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(698, 322);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(64, 13);
            this.label12.TabIndex = 141;
            this.label12.Text = "PRODUTO:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(482, 322);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(47, 13);
            this.label11.TabIndex = 140;
            this.label11.Text = "SETOR:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(53, 323);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 13);
            this.label1.TabIndex = 139;
            this.label1.Text = "ASSUNTO:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(968, 241);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(24, 13);
            this.label9.TabIndex = 138;
            this.label9.Text = "UF:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(1068, 241);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(50, 13);
            this.label8.TabIndex = 137;
            this.label8.Text = "CIDADE:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(587, 241);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(22, 13);
            this.label7.TabIndex = 136;
            this.label7.Text = "Nº:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(702, 241);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(51, 13);
            this.label6.TabIndex = 135;
            this.label6.Text = "BAIRRO:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(50, 241);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(70, 13);
            this.label5.TabIndex = 134;
            this.label5.Text = "ENDERECO:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(743, 162);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(45, 13);
            this.label4.TabIndex = 133;
            this.label4.Text = "E-MAIL:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(525, 162);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(126, 13);
            this.label3.TabIndex = 132;
            this.label3.Text = "TELEFONE / CELULAR:";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(50, 162);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(55, 13);
            this.label16.TabIndex = 131;
            this.label16.Text = "CLIENTE:";
            // 
            // btnCloseForm
            // 
            this.btnCloseForm.BackColor = System.Drawing.Color.White;
            this.btnCloseForm.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnCloseForm.BackgroundImage")));
            this.btnCloseForm.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnCloseForm.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnCloseForm.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnCloseForm.Location = new System.Drawing.Point(1249, 35);
            this.btnCloseForm.Name = "btnCloseForm";
            this.btnCloseForm.Size = new System.Drawing.Size(39, 35);
            this.btnCloseForm.TabIndex = 164;
            this.btnCloseForm.UseVisualStyleBackColor = false;
            this.btnCloseForm.Click += new System.EventHandler(this.btnCloseForm_Click);
            // 
            // label23
            // 
            this.label23.AutoSize = true;
            this.label23.BackColor = System.Drawing.Color.White;
            this.label23.ForeColor = System.Drawing.Color.Black;
            this.label23.Location = new System.Drawing.Point(1249, 82);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(40, 13);
            this.label23.TabIndex = 163;
            this.label23.Text = "Fechar";
            // 
            // frmOrdemServicoInserir
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1350, 730);
            this.Controls.Add(this.btnCloseForm);
            this.Controls.Add(this.label23);
            this.Controls.Add(this.dateTimePickerPrevisaoTermino);
            this.Controls.Add(this.combo_Cidade);
            this.Controls.Add(this.combo_UF);
            this.Controls.Add(this.combo_Categoria);
            this.Controls.Add(this.combo_Setor);
            this.Controls.Add(this.checkOrdemServicoResolvido);
            this.Controls.Add(this.txtProcedimentoRealizado);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.btnOrdemServicoInserir);
            this.Controls.Add(this.txtSolicitacaoCliente);
            this.Controls.Add(this.txtAssunto);
            this.Controls.Add(this.txtBairro);
            this.Controls.Add(this.txtNumero);
            this.Controls.Add(this.txtEndereco);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.txtCelular);
            this.Controls.Add(this.txtNomeCliente);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.btnBuscarCliente);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label18);
            this.Controls.Add(this.txtBuscaCPF);
            this.Controls.Add(this.label17);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "frmOrdemServicoInserir";
            this.Text = "Inserir Ordem de Serviço | My Suite";
            this.Load += new System.EventHandler(this.frmOrdemServicoInserir_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnBuscarCliente;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.TextBox txtBuscaCPF;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.DateTimePicker dateTimePickerPrevisaoTermino;
        private System.Windows.Forms.ComboBox combo_Cidade;
        private System.Windows.Forms.ComboBox combo_UF;
        private System.Windows.Forms.ComboBox combo_Categoria;
        private System.Windows.Forms.ComboBox combo_Setor;
        private System.Windows.Forms.CheckBox checkOrdemServicoResolvido;
        private System.Windows.Forms.TextBox txtProcedimentoRealizado;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Button btnOrdemServicoInserir;
        private System.Windows.Forms.TextBox txtSolicitacaoCliente;
        private System.Windows.Forms.TextBox txtAssunto;
        private System.Windows.Forms.TextBox txtBairro;
        private System.Windows.Forms.TextBox txtNumero;
        private System.Windows.Forms.TextBox txtEndereco;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.TextBox txtCelular;
        private System.Windows.Forms.TextBox txtNomeCliente;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Button btnCloseForm;
        private System.Windows.Forms.Label label23;
    }
}