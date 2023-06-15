namespace HelpDesk_Forms.Views.Gestao
{
    partial class frmRelatorio
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmRelatorio));
            this.panel4 = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.btnSairForm = new System.Windows.Forms.Button();
            this.lblRelatorios = new System.Windows.Forms.Label();
            this.dataGridViewRelatorio = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.combo_Status = new System.Windows.Forms.ComboBox();
            this.combo_User = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtCpfCliente = new System.Windows.Forms.TextBox();
            this.btnPesquisar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewRelatorio)).BeginInit();
            this.SuspendLayout();
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.panel4.Location = new System.Drawing.Point(-6, 94);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(1363, 10);
            this.panel4.TabIndex = 69;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.White;
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.Location = new System.Drawing.Point(1243, 69);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(40, 13);
            this.label5.TabIndex = 81;
            this.label5.Text = "Fechar";
            // 
            // btnSairForm
            // 
            this.btnSairForm.BackColor = System.Drawing.Color.White;
            this.btnSairForm.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnSairForm.BackgroundImage")));
            this.btnSairForm.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnSairForm.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnSairForm.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnSairForm.Location = new System.Drawing.Point(1242, 21);
            this.btnSairForm.Name = "btnSairForm";
            this.btnSairForm.Size = new System.Drawing.Size(39, 35);
            this.btnSairForm.TabIndex = 82;
            this.btnSairForm.UseVisualStyleBackColor = false;
            this.btnSairForm.Click += new System.EventHandler(this.btnSairForm_Click);
            // 
            // lblRelatorios
            // 
            this.lblRelatorios.AutoSize = true;
            this.lblRelatorios.BackColor = System.Drawing.Color.White;
            this.lblRelatorios.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.25F);
            this.lblRelatorios.ForeColor = System.Drawing.Color.Black;
            this.lblRelatorios.Location = new System.Drawing.Point(37, 35);
            this.lblRelatorios.Name = "lblRelatorios";
            this.lblRelatorios.Size = new System.Drawing.Size(251, 22);
            this.lblRelatorios.TabIndex = 83;
            this.lblRelatorios.Text = "Relatórios - Ordem de Serviço";
            // 
            // dataGridViewRelatorio
            // 
            this.dataGridViewRelatorio.AllowUserToAddRows = false;
            this.dataGridViewRelatorio.AllowUserToDeleteRows = false;
            this.dataGridViewRelatorio.AllowUserToOrderColumns = true;
            this.dataGridViewRelatorio.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewRelatorio.Location = new System.Drawing.Point(3, 278);
            this.dataGridViewRelatorio.Name = "dataGridViewRelatorio";
            this.dataGridViewRelatorio.ReadOnly = true;
            this.dataGridViewRelatorio.Size = new System.Drawing.Size(1354, 449);
            this.dataGridViewRelatorio.TabIndex = 165;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.White;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.25F);
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(37, 128);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(166, 22);
            this.label1.TabIndex = 166;
            this.label1.Text = "Filtros de pesquisa:";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(274, 175);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(79, 13);
            this.label13.TabIndex = 167;
            this.label13.Text = "POR STATUS:";
            // 
            // combo_Status
            // 
            this.combo_Status.FormattingEnabled = true;
            this.combo_Status.Location = new System.Drawing.Point(277, 202);
            this.combo_Status.Name = "combo_Status";
            this.combo_Status.Size = new System.Drawing.Size(190, 21);
            this.combo_Status.TabIndex = 168;
            // 
            // combo_User
            // 
            this.combo_User.FormattingEnabled = true;
            this.combo_User.Location = new System.Drawing.Point(496, 202);
            this.combo_User.Name = "combo_User";
            this.combo_User.Size = new System.Drawing.Size(190, 21);
            this.combo_User.TabIndex = 170;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(493, 175);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(137, 13);
            this.label2.TabIndex = 169;
            this.label2.Text = "POR USUARIO CRIADOR:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(38, 176);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(104, 13);
            this.label3.TabIndex = 171;
            this.label3.Text = "POR CPF CLIENTE:";
            // 
            // txtCpfCliente
            // 
            this.txtCpfCliente.BackColor = System.Drawing.SystemColors.Menu;
            this.txtCpfCliente.Location = new System.Drawing.Point(41, 203);
            this.txtCpfCliente.Name = "txtCpfCliente";
            this.txtCpfCliente.Size = new System.Drawing.Size(209, 20);
            this.txtCpfCliente.TabIndex = 172;
            // 
            // btnPesquisar
            // 
            this.btnPesquisar.Location = new System.Drawing.Point(710, 200);
            this.btnPesquisar.Name = "btnPesquisar";
            this.btnPesquisar.Size = new System.Drawing.Size(75, 23);
            this.btnPesquisar.TabIndex = 173;
            this.btnPesquisar.Text = "Pesquisar";
            this.btnPesquisar.UseVisualStyleBackColor = true;
            this.btnPesquisar.Click += new System.EventHandler(this.btnPesquisar_Click);
            // 
            // frmRelatorio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1350, 730);
            this.Controls.Add(this.btnPesquisar);
            this.Controls.Add(this.txtCpfCliente);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.combo_User);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.combo_Status);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridViewRelatorio);
            this.Controls.Add(this.lblRelatorios);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.btnSairForm);
            this.Controls.Add(this.panel4);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "frmRelatorio";
            this.Text = "frmRelatorio";
            this.Load += new System.EventHandler(this.frmRelatorio_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewRelatorio)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnSairForm;
        private System.Windows.Forms.Label lblRelatorios;
        private System.Windows.Forms.DataGridView dataGridViewRelatorio;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.ComboBox combo_Status;
        private System.Windows.Forms.ComboBox combo_User;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtCpfCliente;
        private System.Windows.Forms.Button btnPesquisar;
    }
}