namespace HelpDesk_Forms.Views.Nivel_1
{
    partial class frmOrdemServico
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmOrdemServico));
            this.panel4 = new System.Windows.Forms.Panel();
            this.btnCriarOrdemServico = new System.Windows.Forms.Button();
            this.btnEditarOrdemServico = new System.Windows.Forms.Button();
            this.btnCancelarOrdemServico = new System.Windows.Forms.Button();
            this.label18 = new System.Windows.Forms.Label();
            this.dataGridViewOrdemServicoAbertos = new System.Windows.Forms.DataGridView();
            this.label5 = new System.Windows.Forms.Label();
            this.btnSairForm = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtCount = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewOrdemServicoAbertos)).BeginInit();
            this.SuspendLayout();
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.panel4.Location = new System.Drawing.Point(-6, 91);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(1363, 10);
            this.panel4.TabIndex = 17;
            // 
            // btnCriarOrdemServico
            // 
            this.btnCriarOrdemServico.BackColor = System.Drawing.SystemColors.Control;
            this.btnCriarOrdemServico.ForeColor = System.Drawing.Color.Black;
            this.btnCriarOrdemServico.Location = new System.Drawing.Point(47, 53);
            this.btnCriarOrdemServico.Name = "btnCriarOrdemServico";
            this.btnCriarOrdemServico.Size = new System.Drawing.Size(75, 23);
            this.btnCriarOrdemServico.TabIndex = 59;
            this.btnCriarOrdemServico.Text = "Criar OS";
            this.btnCriarOrdemServico.UseVisualStyleBackColor = false;
            this.btnCriarOrdemServico.Click += new System.EventHandler(this.btnCriarOrdemServico_Click);
            // 
            // btnEditarOrdemServico
            // 
            this.btnEditarOrdemServico.BackColor = System.Drawing.SystemColors.Control;
            this.btnEditarOrdemServico.ForeColor = System.Drawing.Color.Black;
            this.btnEditarOrdemServico.Location = new System.Drawing.Point(155, 53);
            this.btnEditarOrdemServico.Name = "btnEditarOrdemServico";
            this.btnEditarOrdemServico.Size = new System.Drawing.Size(75, 23);
            this.btnEditarOrdemServico.TabIndex = 60;
            this.btnEditarOrdemServico.Text = "Editar OS";
            this.btnEditarOrdemServico.UseVisualStyleBackColor = false;
            this.btnEditarOrdemServico.Click += new System.EventHandler(this.btnEditarOrdemServico_Click);
            // 
            // btnCancelarOrdemServico
            // 
            this.btnCancelarOrdemServico.BackColor = System.Drawing.SystemColors.Control;
            this.btnCancelarOrdemServico.ForeColor = System.Drawing.Color.Black;
            this.btnCancelarOrdemServico.Location = new System.Drawing.Point(263, 53);
            this.btnCancelarOrdemServico.Name = "btnCancelarOrdemServico";
            this.btnCancelarOrdemServico.Size = new System.Drawing.Size(75, 23);
            this.btnCancelarOrdemServico.TabIndex = 61;
            this.btnCancelarOrdemServico.Text = "Cancelar OS";
            this.btnCancelarOrdemServico.UseVisualStyleBackColor = false;
            this.btnCancelarOrdemServico.Click += new System.EventHandler(this.btnCancelarOrdemServico_Click);
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.BackColor = System.Drawing.Color.White;
            this.label18.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.25F);
            this.label18.ForeColor = System.Drawing.Color.Black;
            this.label18.Location = new System.Drawing.Point(46, 14);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(154, 22);
            this.label18.TabIndex = 62;
            this.label18.Text = "Ordem de Serviço";
            // 
            // dataGridViewOrdemServicoAbertos
            // 
            this.dataGridViewOrdemServicoAbertos.AllowUserToAddRows = false;
            this.dataGridViewOrdemServicoAbertos.AllowUserToDeleteRows = false;
            this.dataGridViewOrdemServicoAbertos.AllowUserToOrderColumns = true;
            this.dataGridViewOrdemServicoAbertos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewOrdemServicoAbertos.Location = new System.Drawing.Point(-2, 144);
            this.dataGridViewOrdemServicoAbertos.Name = "dataGridViewOrdemServicoAbertos";
            this.dataGridViewOrdemServicoAbertos.ReadOnly = true;
            this.dataGridViewOrdemServicoAbertos.Size = new System.Drawing.Size(1359, 586);
            this.dataGridViewOrdemServicoAbertos.TabIndex = 65;
            this.dataGridViewOrdemServicoAbertos.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewOrdemServicoAbertos_CellContentClick);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.White;
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.Location = new System.Drawing.Point(1252, 63);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(40, 13);
            this.label5.TabIndex = 75;
            this.label5.Text = "Fechar";
            // 
            // btnSairForm
            // 
            this.btnSairForm.BackColor = System.Drawing.Color.White;
            this.btnSairForm.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnSairForm.BackgroundImage")));
            this.btnSairForm.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnSairForm.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnSairForm.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnSairForm.Location = new System.Drawing.Point(1251, 15);
            this.btnSairForm.Name = "btnSairForm";
            this.btnSairForm.Size = new System.Drawing.Size(39, 35);
            this.btnSairForm.TabIndex = 76;
            this.btnSairForm.UseVisualStyleBackColor = false;
            this.btnSairForm.Click += new System.EventHandler(this.btnSairForm_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.White;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.25F);
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(45, 111);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(168, 22);
            this.label1.TabIndex = 77;
            this.label1.Text = "Chamados Abertos:";
            // 
            // txtCount
            // 
            this.txtCount.AutoSize = true;
            this.txtCount.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCount.Location = new System.Drawing.Point(217, 116);
            this.txtCount.Name = "txtCount";
            this.txtCount.Size = new System.Drawing.Size(15, 16);
            this.txtCount.TabIndex = 78;
            this.txtCount.Text = "0";
            // 
            // frmOrdemServico
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1350, 730);
            this.Controls.Add(this.txtCount);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.btnSairForm);
            this.Controls.Add(this.dataGridViewOrdemServicoAbertos);
            this.Controls.Add(this.label18);
            this.Controls.Add(this.btnCancelarOrdemServico);
            this.Controls.Add(this.btnEditarOrdemServico);
            this.Controls.Add(this.btnCriarOrdemServico);
            this.Controls.Add(this.panel4);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "frmOrdemServico";
            this.Text = "Ordem de Servico | My Suite";
            this.Load += new System.EventHandler(this.frmOrdemServico_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewOrdemServicoAbertos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Button btnCriarOrdemServico;
        private System.Windows.Forms.Button btnEditarOrdemServico;
        private System.Windows.Forms.Button btnCancelarOrdemServico;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.DataGridView dataGridViewOrdemServicoAbertos;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnSairForm;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label txtCount;
    }
}