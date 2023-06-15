namespace HelpDesk_Forms.Views.Nivel_1
{
    partial class frmOrdemServicoCancelar
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmOrdemServicoCancelar));
            this.panel4 = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.txtSearchOrdemServico = new System.Windows.Forms.TextBox();
            this.btnPesquisarOrdemServico = new System.Windows.Forms.Button();
            this.label18 = new System.Windows.Forms.Label();
            this.dataGridOrdemServicoCancelar = new System.Windows.Forms.DataGridView();
            this.txtMotivoCancelamento = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnCancelarOrdemServico = new System.Windows.Forms.Button();
            this.btnCloseForm = new System.Windows.Forms.Button();
            this.label14 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridOrdemServicoCancelar)).BeginInit();
            this.SuspendLayout();
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.panel4.Location = new System.Drawing.Point(-6, 100);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(1363, 10);
            this.panel4.TabIndex = 122;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.White;
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.Location = new System.Drawing.Point(38, 68);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(61, 13);
            this.label5.TabIndex = 120;
            this.label5.Text = "Código OS:";
            // 
            // txtSearchOrdemServico
            // 
            this.txtSearchOrdemServico.BackColor = System.Drawing.Color.White;
            this.txtSearchOrdemServico.ForeColor = System.Drawing.Color.Black;
            this.txtSearchOrdemServico.Location = new System.Drawing.Point(108, 64);
            this.txtSearchOrdemServico.Name = "txtSearchOrdemServico";
            this.txtSearchOrdemServico.Size = new System.Drawing.Size(113, 20);
            this.txtSearchOrdemServico.TabIndex = 121;
            // 
            // btnPesquisarOrdemServico
            // 
            this.btnPesquisarOrdemServico.BackColor = System.Drawing.SystemColors.Control;
            this.btnPesquisarOrdemServico.ForeColor = System.Drawing.Color.Black;
            this.btnPesquisarOrdemServico.Location = new System.Drawing.Point(256, 63);
            this.btnPesquisarOrdemServico.Name = "btnPesquisarOrdemServico";
            this.btnPesquisarOrdemServico.Size = new System.Drawing.Size(75, 23);
            this.btnPesquisarOrdemServico.TabIndex = 116;
            this.btnPesquisarOrdemServico.Text = "Buscar";
            this.btnPesquisarOrdemServico.UseVisualStyleBackColor = false;
            this.btnPesquisarOrdemServico.Click += new System.EventHandler(this.btnPesquisarOrdemServico_Click);
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.BackColor = System.Drawing.Color.White;
            this.label18.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.25F);
            this.label18.ForeColor = System.Drawing.Color.Black;
            this.label18.Location = new System.Drawing.Point(32, 20);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(299, 22);
            this.label18.TabIndex = 119;
            this.label18.Text = "Cancelamento de Ordem de Serviço";
            // 
            // dataGridOrdemServicoCancelar
            // 
            this.dataGridOrdemServicoCancelar.AllowUserToAddRows = false;
            this.dataGridOrdemServicoCancelar.AllowUserToDeleteRows = false;
            this.dataGridOrdemServicoCancelar.AllowUserToOrderColumns = true;
            this.dataGridOrdemServicoCancelar.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridOrdemServicoCancelar.Location = new System.Drawing.Point(-2, 112);
            this.dataGridOrdemServicoCancelar.Name = "dataGridOrdemServicoCancelar";
            this.dataGridOrdemServicoCancelar.ReadOnly = true;
            this.dataGridOrdemServicoCancelar.Size = new System.Drawing.Size(1354, 62);
            this.dataGridOrdemServicoCancelar.TabIndex = 126;
            // 
            // txtMotivoCancelamento
            // 
            this.txtMotivoCancelamento.Location = new System.Drawing.Point(337, 350);
            this.txtMotivoCancelamento.Multiline = true;
            this.txtMotivoCancelamento.Name = "txtMotivoCancelamento";
            this.txtMotivoCancelamento.Size = new System.Drawing.Size(757, 56);
            this.txtMotivoCancelamento.TabIndex = 127;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.White;
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(615, 310);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(176, 13);
            this.label1.TabIndex = 128;
            this.label1.Text = "Informe o motivo do cancelamento::";
            // 
            // btnCancelarOrdemServico
            // 
            this.btnCancelarOrdemServico.BackColor = System.Drawing.SystemColors.Control;
            this.btnCancelarOrdemServico.ForeColor = System.Drawing.Color.Black;
            this.btnCancelarOrdemServico.Location = new System.Drawing.Point(668, 453);
            this.btnCancelarOrdemServico.Name = "btnCancelarOrdemServico";
            this.btnCancelarOrdemServico.Size = new System.Drawing.Size(75, 23);
            this.btnCancelarOrdemServico.TabIndex = 129;
            this.btnCancelarOrdemServico.Text = "Confirmar";
            this.btnCancelarOrdemServico.UseVisualStyleBackColor = false;
            this.btnCancelarOrdemServico.Click += new System.EventHandler(this.btnCancelarOrdemServico_Click);
            // 
            // btnCloseForm
            // 
            this.btnCloseForm.BackColor = System.Drawing.Color.White;
            this.btnCloseForm.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnCloseForm.BackgroundImage")));
            this.btnCloseForm.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnCloseForm.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnCloseForm.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnCloseForm.Location = new System.Drawing.Point(1266, 21);
            this.btnCloseForm.Name = "btnCloseForm";
            this.btnCloseForm.Size = new System.Drawing.Size(39, 35);
            this.btnCloseForm.TabIndex = 164;
            this.btnCloseForm.UseVisualStyleBackColor = false;
            this.btnCloseForm.Click += new System.EventHandler(this.btnCloseForm_Click);
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.BackColor = System.Drawing.Color.White;
            this.label14.ForeColor = System.Drawing.Color.Black;
            this.label14.Location = new System.Drawing.Point(1266, 68);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(40, 13);
            this.label14.TabIndex = 163;
            this.label14.Text = "Fechar";
            // 
            // frmOrdemServicoCancelar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1350, 730);
            this.Controls.Add(this.btnCloseForm);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.btnCancelarOrdemServico);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtMotivoCancelamento);
            this.Controls.Add(this.dataGridOrdemServicoCancelar);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtSearchOrdemServico);
            this.Controls.Add(this.btnPesquisarOrdemServico);
            this.Controls.Add(this.label18);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "frmOrdemServicoCancelar";
            this.Text = "Cancelar Ordem de Serviço | My Suite";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridOrdemServicoCancelar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtSearchOrdemServico;
        private System.Windows.Forms.Button btnPesquisarOrdemServico;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.DataGridView dataGridOrdemServicoCancelar;
        private System.Windows.Forms.TextBox txtMotivoCancelamento;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnCancelarOrdemServico;
        private System.Windows.Forms.Button btnCloseForm;
        private System.Windows.Forms.Label label14;
    }
}