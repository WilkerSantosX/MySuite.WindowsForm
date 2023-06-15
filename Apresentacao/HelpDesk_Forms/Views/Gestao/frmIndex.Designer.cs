namespace HelpDesk_Forms.Views.Gestao
{
    partial class frmIndex
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmIndex));
            this.btnProduto_Grid = new System.Windows.Forms.Button();
            this.btnUsuario_Grid = new System.Windows.Forms.Button();
            this.label10 = new System.Windows.Forms.Label();
            this.btnSair = new System.Windows.Forms.Button();
            this.panel4 = new System.Windows.Forms.Panel();
            this.labelCountAcesso = new System.Windows.Forms.Label();
            this.labelUsuario = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnRelatorio_Grid = new System.Windows.Forms.Button();
            this.labelDataAcesso = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnProduto_Grid
            // 
            this.btnProduto_Grid.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.btnProduto_Grid.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnProduto_Grid.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnProduto_Grid.Location = new System.Drawing.Point(548, -9);
            this.btnProduto_Grid.Name = "btnProduto_Grid";
            this.btnProduto_Grid.Size = new System.Drawing.Size(176, 103);
            this.btnProduto_Grid.TabIndex = 61;
            this.btnProduto_Grid.Text = "Produtos";
            this.btnProduto_Grid.UseVisualStyleBackColor = false;
            this.btnProduto_Grid.Click += new System.EventHandler(this.btnProduto_Grid_Click);
            // 
            // btnUsuario_Grid
            // 
            this.btnUsuario_Grid.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.btnUsuario_Grid.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnUsuario_Grid.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUsuario_Grid.Location = new System.Drawing.Point(211, -9);
            this.btnUsuario_Grid.Name = "btnUsuario_Grid";
            this.btnUsuario_Grid.Size = new System.Drawing.Size(176, 103);
            this.btnUsuario_Grid.TabIndex = 60;
            this.btnUsuario_Grid.Text = "Usuarios";
            this.btnUsuario_Grid.UseVisualStyleBackColor = false;
            this.btnUsuario_Grid.Click += new System.EventHandler(this.btnUsuario_Grid_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.Color.White;
            this.label10.ForeColor = System.Drawing.Color.Black;
            this.label10.Location = new System.Drawing.Point(1195, 66);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(25, 13);
            this.label10.TabIndex = 59;
            this.label10.Text = "Sair";
            // 
            // btnSair
            // 
            this.btnSair.BackColor = System.Drawing.Color.White;
            this.btnSair.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnSair.BackgroundImage")));
            this.btnSair.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnSair.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnSair.ForeColor = System.Drawing.Color.White;
            this.btnSair.Location = new System.Drawing.Point(1189, 17);
            this.btnSair.Name = "btnSair";
            this.btnSair.Size = new System.Drawing.Size(39, 35);
            this.btnSair.TabIndex = 58;
            this.btnSair.UseVisualStyleBackColor = false;
            this.btnSair.Click += new System.EventHandler(this.btnSair_Click);
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.panel4.Location = new System.Drawing.Point(-6, 93);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(1363, 10);
            this.panel4.TabIndex = 57;
            // 
            // labelCountAcesso
            // 
            this.labelCountAcesso.AutoSize = true;
            this.labelCountAcesso.BackColor = System.Drawing.Color.White;
            this.labelCountAcesso.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCountAcesso.ForeColor = System.Drawing.Color.Black;
            this.labelCountAcesso.Location = new System.Drawing.Point(546, 354);
            this.labelCountAcesso.Name = "labelCountAcesso";
            this.labelCountAcesso.Size = new System.Drawing.Size(241, 18);
            this.labelCountAcesso.TabIndex = 66;
            this.labelCountAcesso.Text = "Este é o seu 1º acesso ao sistema!";
            // 
            // labelUsuario
            // 
            this.labelUsuario.AutoSize = true;
            this.labelUsuario.BackColor = System.Drawing.Color.White;
            this.labelUsuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelUsuario.ForeColor = System.Drawing.Color.Black;
            this.labelUsuario.Location = new System.Drawing.Point(545, 327);
            this.labelUsuario.Name = "labelUsuario";
            this.labelUsuario.Size = new System.Drawing.Size(101, 18);
            this.labelUsuario.TabIndex = 65;
            this.labelUsuario.Text = "Wilker Santos";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.White;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(544, 299);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(37, 20);
            this.label4.TabIndex = 64;
            this.label4.Text = "Olá,";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.SystemColors.Window;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.Black;
            this.label9.Location = new System.Drawing.Point(361, 221);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(613, 33);
            this.label9.TabIndex = 63;
            this.label9.Text = "Plataforma de Gerenciamento | Administrativo";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(513, 446);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(331, 64);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 62;
            this.pictureBox1.TabStop = false;
            // 
            // btnRelatorio_Grid
            // 
            this.btnRelatorio_Grid.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.btnRelatorio_Grid.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnRelatorio_Grid.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRelatorio_Grid.Location = new System.Drawing.Point(878, -9);
            this.btnRelatorio_Grid.Name = "btnRelatorio_Grid";
            this.btnRelatorio_Grid.Size = new System.Drawing.Size(176, 103);
            this.btnRelatorio_Grid.TabIndex = 67;
            this.btnRelatorio_Grid.Text = "Relatorios";
            this.btnRelatorio_Grid.UseVisualStyleBackColor = false;
            this.btnRelatorio_Grid.Click += new System.EventHandler(this.btnRelatorio_Grid_Click);
            // 
            // labelDataAcesso
            // 
            this.labelDataAcesso.AutoSize = true;
            this.labelDataAcesso.BackColor = System.Drawing.Color.White;
            this.labelDataAcesso.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelDataAcesso.ForeColor = System.Drawing.Color.Black;
            this.labelDataAcesso.Location = new System.Drawing.Point(650, 299);
            this.labelDataAcesso.Name = "labelDataAcesso";
            this.labelDataAcesso.Size = new System.Drawing.Size(120, 18);
            this.labelDataAcesso.TabIndex = 143;
            this.labelDataAcesso.Text = "25/02/2018 18:50";
            // 
            // frmIndex
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1350, 730);
            this.Controls.Add(this.labelDataAcesso);
            this.Controls.Add(this.labelCountAcesso);
            this.Controls.Add(this.labelUsuario);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.btnSair);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.btnUsuario_Grid);
            this.Controls.Add(this.btnProduto_Grid);
            this.Controls.Add(this.btnRelatorio_Grid);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "frmIndex";
            this.Text = "frmIndex";
            this.Load += new System.EventHandler(this.frmIndex_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnProduto_Grid;
        private System.Windows.Forms.Button btnUsuario_Grid;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button btnSair;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label labelCountAcesso;
        private System.Windows.Forms.Label labelUsuario;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnRelatorio_Grid;
        private System.Windows.Forms.Label labelDataAcesso;
    }
}