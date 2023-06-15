namespace HelpDesk_Forms.Views.Gestao
{
    partial class FrmProduto
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmProduto));
            this.panel4 = new System.Windows.Forms.Panel();
            this.label18 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.btnSairForm = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnInserirProduto = new System.Windows.Forms.Button();
            this.txtNomeProduto = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnInativarProduto = new System.Windows.Forms.Button();
            this.txtNomeProdutoInativar = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.dataGridViewProduto = new System.Windows.Forms.DataGridView();
            this.dataGridViewProdutoInativo = new System.Windows.Forms.DataGridView();
            this.label4 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewProduto)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewProdutoInativo)).BeginInit();
            this.SuspendLayout();
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.panel4.Location = new System.Drawing.Point(-6, 92);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(1363, 10);
            this.panel4.TabIndex = 68;
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.BackColor = System.Drawing.Color.White;
            this.label18.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.25F);
            this.label18.ForeColor = System.Drawing.Color.Black;
            this.label18.Location = new System.Drawing.Point(47, 34);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(234, 22);
            this.label18.TabIndex = 69;
            this.label18.Text = "Gerenciamento de Produtos";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.White;
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.Location = new System.Drawing.Point(1247, 65);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(40, 13);
            this.label5.TabIndex = 79;
            this.label5.Text = "Fechar";
            // 
            // btnSairForm
            // 
            this.btnSairForm.BackColor = System.Drawing.Color.White;
            this.btnSairForm.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnSairForm.BackgroundImage")));
            this.btnSairForm.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnSairForm.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnSairForm.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnSairForm.Location = new System.Drawing.Point(1246, 17);
            this.btnSairForm.Name = "btnSairForm";
            this.btnSairForm.Size = new System.Drawing.Size(39, 35);
            this.btnSairForm.TabIndex = 80;
            this.btnSairForm.UseVisualStyleBackColor = false;
            this.btnSairForm.Click += new System.EventHandler(this.btnSairForm_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.White;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.25F);
            this.label9.ForeColor = System.Drawing.Color.Black;
            this.label9.Location = new System.Drawing.Point(760, 147);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(68, 22);
            this.label9.TabIndex = 156;
            this.label9.Text = "Inativar";
            this.label9.Click += new System.EventHandler(this.label9_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.White;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.25F);
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(49, 147);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(89, 22);
            this.label1.TabIndex = 155;
            this.label1.Text = "Cadastrar";
            // 
            // btnInserirProduto
            // 
            this.btnInserirProduto.BackColor = System.Drawing.SystemColors.Control;
            this.btnInserirProduto.ForeColor = System.Drawing.Color.Black;
            this.btnInserirProduto.Location = new System.Drawing.Point(53, 258);
            this.btnInserirProduto.Name = "btnInserirProduto";
            this.btnInserirProduto.Size = new System.Drawing.Size(94, 23);
            this.btnInserirProduto.TabIndex = 160;
            this.btnInserirProduto.Text = "Inserir";
            this.btnInserirProduto.UseVisualStyleBackColor = false;
            this.btnInserirProduto.Click += new System.EventHandler(this.btnInserirProduto_Click);
            // 
            // txtNomeProduto
            // 
            this.txtNomeProduto.BackColor = System.Drawing.SystemColors.Menu;
            this.txtNomeProduto.Location = new System.Drawing.Point(54, 214);
            this.txtNomeProduto.Name = "txtNomeProduto";
            this.txtNomeProduto.Size = new System.Drawing.Size(209, 20);
            this.txtNomeProduto.TabIndex = 159;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(51, 188);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(118, 13);
            this.label2.TabIndex = 158;
            this.label2.Text = "NOME DO PRODUTO:";
            // 
            // btnInativarProduto
            // 
            this.btnInativarProduto.BackColor = System.Drawing.SystemColors.Control;
            this.btnInativarProduto.ForeColor = System.Drawing.Color.Black;
            this.btnInativarProduto.Location = new System.Drawing.Point(765, 258);
            this.btnInativarProduto.Name = "btnInativarProduto";
            this.btnInativarProduto.Size = new System.Drawing.Size(94, 23);
            this.btnInativarProduto.TabIndex = 163;
            this.btnInativarProduto.Text = "Inativar";
            this.btnInativarProduto.UseVisualStyleBackColor = false;
            this.btnInativarProduto.Click += new System.EventHandler(this.btnInativarProduto_Click);
            // 
            // txtNomeProdutoInativar
            // 
            this.txtNomeProdutoInativar.BackColor = System.Drawing.SystemColors.Menu;
            this.txtNomeProdutoInativar.Location = new System.Drawing.Point(765, 214);
            this.txtNomeProdutoInativar.Name = "txtNomeProdutoInativar";
            this.txtNomeProdutoInativar.Size = new System.Drawing.Size(209, 20);
            this.txtNomeProdutoInativar.TabIndex = 162;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(762, 188);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(128, 13);
            this.label3.TabIndex = 161;
            this.label3.Text = "CÓDIGO DO PRODUTO:";
            // 
            // dataGridViewProduto
            // 
            this.dataGridViewProduto.AllowUserToAddRows = false;
            this.dataGridViewProduto.AllowUserToDeleteRows = false;
            this.dataGridViewProduto.AllowUserToOrderColumns = true;
            this.dataGridViewProduto.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewProduto.Location = new System.Drawing.Point(51, 351);
            this.dataGridViewProduto.Name = "dataGridViewProduto";
            this.dataGridViewProduto.ReadOnly = true;
            this.dataGridViewProduto.Size = new System.Drawing.Size(516, 249);
            this.dataGridViewProduto.TabIndex = 164;
            // 
            // dataGridViewProdutoInativo
            // 
            this.dataGridViewProdutoInativo.AllowUserToAddRows = false;
            this.dataGridViewProdutoInativo.AllowUserToDeleteRows = false;
            this.dataGridViewProdutoInativo.AllowUserToOrderColumns = true;
            this.dataGridViewProdutoInativo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewProdutoInativo.Location = new System.Drawing.Point(765, 351);
            this.dataGridViewProdutoInativo.Name = "dataGridViewProdutoInativo";
            this.dataGridViewProdutoInativo.ReadOnly = true;
            this.dataGridViewProdutoInativo.Size = new System.Drawing.Size(516, 238);
            this.dataGridViewProdutoInativo.TabIndex = 165;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(50, 315);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(99, 13);
            this.label4.TabIndex = 166;
            this.label4.Text = "PRODUTO ATIVO:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(762, 315);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(110, 13);
            this.label6.TabIndex = 167;
            this.label6.Text = "PRODUTO INATIVO:";
            // 
            // FrmProduto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1350, 730);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.dataGridViewProdutoInativo);
            this.Controls.Add(this.dataGridViewProduto);
            this.Controls.Add(this.btnInativarProduto);
            this.Controls.Add(this.txtNomeProdutoInativar);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnInserirProduto);
            this.Controls.Add(this.txtNomeProduto);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.btnSairForm);
            this.Controls.Add(this.label18);
            this.Controls.Add(this.panel4);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "FrmProduto";
            this.Text = "FrmProduto";
            this.Load += new System.EventHandler(this.FrmProduto_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewProduto)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewProdutoInativo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnSairForm;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnInserirProduto;
        private System.Windows.Forms.TextBox txtNomeProduto;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnInativarProduto;
        private System.Windows.Forms.TextBox txtNomeProdutoInativar;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridView dataGridViewProduto;
        private System.Windows.Forms.DataGridView dataGridViewProdutoInativo;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label6;
    }
}