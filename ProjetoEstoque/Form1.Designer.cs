namespace ProjetoEstoque
{
    partial class Form1
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.lblHistórico = new System.Windows.Forms.Label();
            this.lblEstoque = new System.Windows.Forms.Label();
            this.lblFaturamento = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // lblHistórico
            // 
            this.lblHistórico.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblHistórico.BackColor = System.Drawing.Color.Transparent;
            this.lblHistórico.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHistórico.ForeColor = System.Drawing.SystemColors.WindowText;
            this.lblHistórico.Image = ((System.Drawing.Image)(resources.GetObject("lblHistórico.Image")));
            this.lblHistórico.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.lblHistórico.Location = new System.Drawing.Point(32, 59);
            this.lblHistórico.Name = "lblHistórico";
            this.lblHistórico.Size = new System.Drawing.Size(149, 156);
            this.lblHistórico.TabIndex = 3;
            this.lblHistórico.Text = "Histórico";
            this.lblHistórico.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.lblHistórico.Click += new System.EventHandler(this.lblHistórico_Click);
            this.lblHistórico.MouseEnter += new System.EventHandler(this.lblHistórico_MouseEnter);
            this.lblHistórico.MouseLeave += new System.EventHandler(this.lblHistórico_MouseLeave);
            // 
            // lblEstoque
            // 
            this.lblEstoque.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblEstoque.BackColor = System.Drawing.Color.Transparent;
            this.lblEstoque.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEstoque.ForeColor = System.Drawing.SystemColors.WindowText;
            this.lblEstoque.Image = ((System.Drawing.Image)(resources.GetObject("lblEstoque.Image")));
            this.lblEstoque.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.lblEstoque.Location = new System.Drawing.Point(134, 299);
            this.lblEstoque.Name = "lblEstoque";
            this.lblEstoque.Size = new System.Drawing.Size(152, 156);
            this.lblEstoque.TabIndex = 2;
            this.lblEstoque.Text = "Estoque";
            this.lblEstoque.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.lblEstoque.Click += new System.EventHandler(this.lblEstoque_Click);
            this.lblEstoque.MouseEnter += new System.EventHandler(this.lblEstoque_MouseEnter);
            this.lblEstoque.MouseLeave += new System.EventHandler(this.lblEstoque_MouseLeave);
            // 
            // lblFaturamento
            // 
            this.lblFaturamento.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblFaturamento.BackColor = System.Drawing.Color.Transparent;
            this.lblFaturamento.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFaturamento.ForeColor = System.Drawing.SystemColors.WindowText;
            this.lblFaturamento.Image = ((System.Drawing.Image)(resources.GetObject("lblFaturamento.Image")));
            this.lblFaturamento.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.lblFaturamento.Location = new System.Drawing.Point(243, 87);
            this.lblFaturamento.Name = "lblFaturamento";
            this.lblFaturamento.Size = new System.Drawing.Size(158, 128);
            this.lblFaturamento.TabIndex = 31;
            this.lblFaturamento.Text = "Faturamento";
            this.lblFaturamento.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.lblFaturamento.Click += new System.EventHandler(this.lblFaturamento_Click);
            this.lblFaturamento.MouseEnter += new System.EventHandler(this.lblFaturamento_MouseEnter);
            this.lblFaturamento.MouseLeave += new System.EventHandler(this.lblFaturamento_MouseLeave);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(675, -7);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(135, 127);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 32;
            this.pictureBox1.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(785, 560);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.lblEstoque);
            this.Controls.Add(this.lblFaturamento);
            this.Controls.Add(this.lblHistórico);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SFG";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label lblHistórico;
        private System.Windows.Forms.Label lblEstoque;
        private System.Windows.Forms.Label lblFaturamento;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

