namespace HelpDesk_Forms.Views.Nivel_2
{
    partial class frmOrdemServicoFinalizar
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmOrdemServicoFinalizar));
            this.labelCodigoOS = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.label23 = new System.Windows.Forms.Label();
            this.btnFinalizarOrdemServico = new System.Windows.Forms.Button();
            this.label24 = new System.Windows.Forms.Label();
            this.combo_produto = new System.Windows.Forms.ComboBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.txtObservacaoTecnica = new System.Windows.Forms.TextBox();
            this.label22 = new System.Windows.Forms.Label();
            this.txtAtendimento = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.txtSolicitacao = new System.Windows.Forms.TextBox();
            this.txtAssunto = new System.Windows.Forms.TextBox();
            this.txtBairro = new System.Windows.Forms.TextBox();
            this.txtNumero = new System.Windows.Forms.TextBox();
            this.txtEndereco = new System.Windows.Forms.TextBox();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.txtTelefone = new System.Windows.Forms.TextBox();
            this.txtCliente = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.label20 = new System.Windows.Forms.Label();
            this.label21 = new System.Windows.Forms.Label();
            this.label25 = new System.Windows.Forms.Label();
            this.btnCloseForm = new System.Windows.Forms.Button();
            this.txtUF = new System.Windows.Forms.TextBox();
            this.txtCidade = new System.Windows.Forms.TextBox();
            this.txtSetor = new System.Windows.Forms.TextBox();
            this.txtCategoria = new System.Windows.Forms.TextBox();
            this.txtDataConclusao = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // labelCodigoOS
            // 
            this.labelCodigoOS.AutoSize = true;
            this.labelCodigoOS.BackColor = System.Drawing.SystemColors.Window;
            this.labelCodigoOS.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCodigoOS.ForeColor = System.Drawing.Color.Black;
            this.labelCodigoOS.Location = new System.Drawing.Point(442, 33);
            this.labelCodigoOS.Name = "labelCodigoOS";
            this.labelCodigoOS.Size = new System.Drawing.Size(24, 25);
            this.labelCodigoOS.TabIndex = 77;
            this.labelCodigoOS.Text = "0";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.Window;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(26, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(423, 25);
            this.label1.TabIndex = 75;
            this.label1.Text = "Finalização de Ordem de Serviço - Código:";
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.panel4.Location = new System.Drawing.Point(-6, 86);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(1363, 10);
            this.panel4.TabIndex = 69;
            // 
            // label23
            // 
            this.label23.AutoSize = true;
            this.label23.BackColor = System.Drawing.Color.White;
            this.label23.ForeColor = System.Drawing.Color.Black;
            this.label23.Location = new System.Drawing.Point(36, 457);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(152, 13);
            this.label23.TabIndex = 188;
            this.label23.Text = "DADOS DA VISITA TECNICA:";
            // 
            // btnFinalizarOrdemServico
            // 
            this.btnFinalizarOrdemServico.Location = new System.Drawing.Point(639, 664);
            this.btnFinalizarOrdemServico.Name = "btnFinalizarOrdemServico";
            this.btnFinalizarOrdemServico.Size = new System.Drawing.Size(113, 23);
            this.btnFinalizarOrdemServico.TabIndex = 192;
            this.btnFinalizarOrdemServico.Text = "Finalizar";
            this.btnFinalizarOrdemServico.UseVisualStyleBackColor = true;
            this.btnFinalizarOrdemServico.Click += new System.EventHandler(this.btnFinalizarOrdemServico_Click);
            // 
            // label24
            // 
            this.label24.AutoSize = true;
            this.label24.Location = new System.Drawing.Point(45, 516);
            this.label24.Name = "label24";
            this.label24.Size = new System.Drawing.Size(166, 13);
            this.label24.TabIndex = 191;
            this.label24.Text = "HOUVE TROCA DE PRODUTO?";
            // 
            // combo_produto
            // 
            this.combo_produto.FormattingEnabled = true;
            this.combo_produto.Items.AddRange(new object[] {
            "SIM",
            "NÃO"});
            this.combo_produto.Location = new System.Drawing.Point(48, 543);
            this.combo_produto.Name = "combo_produto";
            this.combo_produto.Size = new System.Drawing.Size(121, 21);
            this.combo_produto.TabIndex = 189;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Black;
            this.panel1.Location = new System.Drawing.Point(-6, 480);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1363, 10);
            this.panel1.TabIndex = 190;
            // 
            // txtObservacaoTecnica
            // 
            this.txtObservacaoTecnica.BackColor = System.Drawing.SystemColors.Menu;
            this.txtObservacaoTecnica.Location = new System.Drawing.Point(244, 540);
            this.txtObservacaoTecnica.Multiline = true;
            this.txtObservacaoTecnica.Name = "txtObservacaoTecnica";
            this.txtObservacaoTecnica.Size = new System.Drawing.Size(999, 83);
            this.txtObservacaoTecnica.TabIndex = 187;
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Location = new System.Drawing.Point(243, 516);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(132, 13);
            this.label22.TabIndex = 186;
            this.label22.Text = "OBSERVAÇÃO TÉCNICA:";
            // 
            // txtAtendimento
            // 
            this.txtAtendimento.BackColor = System.Drawing.SystemColors.Menu;
            this.txtAtendimento.Location = new System.Drawing.Point(678, 358);
            this.txtAtendimento.Multiline = true;
            this.txtAtendimento.Name = "txtAtendimento";
            this.txtAtendimento.Size = new System.Drawing.Size(636, 83);
            this.txtAtendimento.TabIndex = 185;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(681, 333);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(175, 13);
            this.label15.TabIndex = 181;
            this.label15.Text = "PROCEDIMENTOS REALIZADOS:";
            // 
            // txtSolicitacao
            // 
            this.txtSolicitacao.BackColor = System.Drawing.SystemColors.Menu;
            this.txtSolicitacao.Location = new System.Drawing.Point(35, 358);
            this.txtSolicitacao.Multiline = true;
            this.txtSolicitacao.Name = "txtSolicitacao";
            this.txtSolicitacao.Size = new System.Drawing.Size(593, 83);
            this.txtSolicitacao.TabIndex = 180;
            // 
            // txtAssunto
            // 
            this.txtAssunto.BackColor = System.Drawing.SystemColors.Menu;
            this.txtAssunto.Location = new System.Drawing.Point(35, 293);
            this.txtAssunto.Multiline = true;
            this.txtAssunto.Name = "txtAssunto";
            this.txtAssunto.Size = new System.Drawing.Size(396, 20);
            this.txtAssunto.TabIndex = 179;
            // 
            // txtBairro
            // 
            this.txtBairro.BackColor = System.Drawing.SystemColors.Menu;
            this.txtBairro.Location = new System.Drawing.Point(684, 216);
            this.txtBairro.Name = "txtBairro";
            this.txtBairro.Size = new System.Drawing.Size(217, 20);
            this.txtBairro.TabIndex = 178;
            // 
            // txtNumero
            // 
            this.txtNumero.BackColor = System.Drawing.SystemColors.Menu;
            this.txtNumero.Location = new System.Drawing.Point(565, 216);
            this.txtNumero.Name = "txtNumero";
            this.txtNumero.Size = new System.Drawing.Size(63, 20);
            this.txtNumero.TabIndex = 177;
            // 
            // txtEndereco
            // 
            this.txtEndereco.BackColor = System.Drawing.SystemColors.Menu;
            this.txtEndereco.Location = new System.Drawing.Point(32, 216);
            this.txtEndereco.Name = "txtEndereco";
            this.txtEndereco.Size = new System.Drawing.Size(491, 20);
            this.txtEndereco.TabIndex = 176;
            // 
            // txtEmail
            // 
            this.txtEmail.BackColor = System.Drawing.SystemColors.Menu;
            this.txtEmail.Location = new System.Drawing.Point(628, 145);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(344, 20);
            this.txtEmail.TabIndex = 175;
            // 
            // txtTelefone
            // 
            this.txtTelefone.BackColor = System.Drawing.SystemColors.Menu;
            this.txtTelefone.Location = new System.Drawing.Point(464, 146);
            this.txtTelefone.Name = "txtTelefone";
            this.txtTelefone.Size = new System.Drawing.Size(146, 20);
            this.txtTelefone.TabIndex = 174;
            // 
            // txtCliente
            // 
            this.txtCliente.BackColor = System.Drawing.SystemColors.Menu;
            this.txtCliente.Location = new System.Drawing.Point(32, 148);
            this.txtCliente.Name = "txtCliente";
            this.txtCliente.Size = new System.Drawing.Size(414, 20);
            this.txtCliente.TabIndex = 173;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(33, 334);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(147, 13);
            this.label14.TabIndex = 172;
            this.label14.Text = "SOLICITACAO DO CLIENTE:";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(894, 260);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(96, 13);
            this.label13.TabIndex = 171;
            this.label13.Text = "DATA PREVISAO:";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(678, 260);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(64, 13);
            this.label12.TabIndex = 170;
            this.label12.Text = "PRODUTO:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(461, 260);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(47, 13);
            this.label11.TabIndex = 169;
            this.label11.Text = "SETOR:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(32, 261);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(62, 13);
            this.label5.TabIndex = 168;
            this.label5.Text = "ASSUNTO:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(947, 186);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(24, 13);
            this.label9.TabIndex = 167;
            this.label9.Text = "UF:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(1056, 186);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(50, 13);
            this.label7.TabIndex = 166;
            this.label7.Text = "CIDADE:";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(566, 186);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(22, 13);
            this.label16.TabIndex = 165;
            this.label16.Text = "Nº:";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(681, 186);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(51, 13);
            this.label17.TabIndex = 163;
            this.label17.Text = "BAIRRO:";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(29, 186);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(70, 13);
            this.label18.TabIndex = 161;
            this.label18.Text = "ENDERECO:";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(625, 119);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(45, 13);
            this.label19.TabIndex = 160;
            this.label19.Text = "E-MAIL:";
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Location = new System.Drawing.Point(464, 120);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(66, 13);
            this.label20.TabIndex = 159;
            this.label20.Text = "TELEFONE:";
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Location = new System.Drawing.Point(29, 122);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(55, 13);
            this.label21.TabIndex = 158;
            this.label21.Text = "CLIENTE:";
            // 
            // label25
            // 
            this.label25.AutoSize = true;
            this.label25.BackColor = System.Drawing.Color.White;
            this.label25.ForeColor = System.Drawing.Color.Black;
            this.label25.Location = new System.Drawing.Point(1258, 63);
            this.label25.Name = "label25";
            this.label25.Size = new System.Drawing.Size(40, 13);
            this.label25.TabIndex = 193;
            this.label25.Text = "Fechar";
            // 
            // btnCloseForm
            // 
            this.btnCloseForm.BackColor = System.Drawing.Color.White;
            this.btnCloseForm.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnCloseForm.BackgroundImage")));
            this.btnCloseForm.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnCloseForm.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnCloseForm.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnCloseForm.Location = new System.Drawing.Point(1257, 15);
            this.btnCloseForm.Name = "btnCloseForm";
            this.btnCloseForm.Size = new System.Drawing.Size(39, 35);
            this.btnCloseForm.TabIndex = 194;
            this.btnCloseForm.UseVisualStyleBackColor = false;
            this.btnCloseForm.Click += new System.EventHandler(this.btnCloseForm_Click);
            // 
            // txtUF
            // 
            this.txtUF.BackColor = System.Drawing.SystemColors.Menu;
            this.txtUF.Location = new System.Drawing.Point(950, 216);
            this.txtUF.Name = "txtUF";
            this.txtUF.Size = new System.Drawing.Size(63, 20);
            this.txtUF.TabIndex = 195;
            // 
            // txtCidade
            // 
            this.txtCidade.BackColor = System.Drawing.SystemColors.Menu;
            this.txtCidade.Location = new System.Drawing.Point(1058, 215);
            this.txtCidade.Name = "txtCidade";
            this.txtCidade.Size = new System.Drawing.Size(184, 20);
            this.txtCidade.TabIndex = 196;
            // 
            // txtSetor
            // 
            this.txtSetor.BackColor = System.Drawing.SystemColors.Menu;
            this.txtSetor.Location = new System.Drawing.Point(464, 292);
            this.txtSetor.Name = "txtSetor";
            this.txtSetor.Size = new System.Drawing.Size(184, 20);
            this.txtSetor.TabIndex = 197;
            // 
            // txtCategoria
            // 
            this.txtCategoria.BackColor = System.Drawing.SystemColors.Menu;
            this.txtCategoria.Location = new System.Drawing.Point(681, 291);
            this.txtCategoria.Name = "txtCategoria";
            this.txtCategoria.Size = new System.Drawing.Size(184, 20);
            this.txtCategoria.TabIndex = 198;
            // 
            // txtDataConclusao
            // 
            this.txtDataConclusao.BackColor = System.Drawing.SystemColors.Menu;
            this.txtDataConclusao.Location = new System.Drawing.Point(897, 292);
            this.txtDataConclusao.Name = "txtDataConclusao";
            this.txtDataConclusao.Size = new System.Drawing.Size(184, 20);
            this.txtDataConclusao.TabIndex = 199;
            // 
            // frmOrdemServicoFinalizar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1350, 730);
            this.Controls.Add(this.txtDataConclusao);
            this.Controls.Add(this.txtCategoria);
            this.Controls.Add(this.txtSetor);
            this.Controls.Add(this.txtCidade);
            this.Controls.Add(this.txtUF);
            this.Controls.Add(this.label25);
            this.Controls.Add(this.btnCloseForm);
            this.Controls.Add(this.label23);
            this.Controls.Add(this.btnFinalizarOrdemServico);
            this.Controls.Add(this.label24);
            this.Controls.Add(this.combo_produto);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.txtObservacaoTecnica);
            this.Controls.Add(this.label22);
            this.Controls.Add(this.txtAtendimento);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.txtSolicitacao);
            this.Controls.Add(this.txtAssunto);
            this.Controls.Add(this.txtBairro);
            this.Controls.Add(this.txtNumero);
            this.Controls.Add(this.txtEndereco);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.txtTelefone);
            this.Controls.Add(this.txtCliente);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.label17);
            this.Controls.Add(this.label18);
            this.Controls.Add(this.label19);
            this.Controls.Add(this.label20);
            this.Controls.Add(this.label21);
            this.Controls.Add(this.labelCodigoOS);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel4);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "frmOrdemServicoFinalizar";
            this.Text = "Finalizar Ordem Servico | My Suite";
            this.Load += new System.EventHandler(this.frmOrdemServicoFinalizar_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelCodigoOS;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label label23;
        private System.Windows.Forms.Button btnFinalizarOrdemServico;
        private System.Windows.Forms.Label label24;
        private System.Windows.Forms.ComboBox combo_produto;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox txtObservacaoTecnica;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.TextBox txtAtendimento;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.TextBox txtSolicitacao;
        private System.Windows.Forms.TextBox txtAssunto;
        private System.Windows.Forms.TextBox txtBairro;
        private System.Windows.Forms.TextBox txtNumero;
        private System.Windows.Forms.TextBox txtEndereco;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.TextBox txtTelefone;
        private System.Windows.Forms.TextBox txtCliente;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.Label label25;
        private System.Windows.Forms.Button btnCloseForm;
        private System.Windows.Forms.TextBox txtUF;
        private System.Windows.Forms.TextBox txtCidade;
        private System.Windows.Forms.TextBox txtSetor;
        private System.Windows.Forms.TextBox txtCategoria;
        private System.Windows.Forms.TextBox txtDataConclusao;
    }
}