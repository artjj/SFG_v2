namespace ProjetoEstoque
{
    partial class Histórico
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Histórico));
            this.dtgHist = new System.Windows.Forms.DataGridView();
            this.pnlHist = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.mnHist = new System.Windows.Forms.MenuStrip();
            this.históricosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.entradasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saídasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.atualizarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.dtgHist)).BeginInit();
            this.pnlHist.SuspendLayout();
            this.mnHist.SuspendLayout();
            this.SuspendLayout();
            // 
            // dtgHist
            // 
            this.dtgHist.AllowUserToOrderColumns = true;
            this.dtgHist.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dtgHist.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            this.dtgHist.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgHist.Location = new System.Drawing.Point(0, 68);
            this.dtgHist.Name = "dtgHist";
            this.dtgHist.Size = new System.Drawing.Size(590, 331);
            this.dtgHist.TabIndex = 0;
            // 
            // pnlHist
            // 
            this.pnlHist.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.pnlHist.Controls.Add(this.button1);
            this.pnlHist.Controls.Add(this.mnHist);
            this.pnlHist.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlHist.Location = new System.Drawing.Point(0, 0);
            this.pnlHist.Name = "pnlHist";
            this.pnlHist.Size = new System.Drawing.Size(590, 71);
            this.pnlHist.TabIndex = 1;
            // 
            // button1
            // 
            this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Image = ((System.Drawing.Image)(resources.GetObject("button1.Image")));
            this.button1.Location = new System.Drawing.Point(468, 10);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(110, 48);
            this.button1.TabIndex = 31;
            this.button1.Text = "Fechar";
            this.button1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // mnHist
            // 
            this.mnHist.AutoSize = false;
            this.mnHist.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.mnHist.Dock = System.Windows.Forms.DockStyle.None;
            this.mnHist.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.históricosToolStripMenuItem});
            this.mnHist.Location = new System.Drawing.Point(9, 10);
            this.mnHist.Name = "mnHist";
            this.mnHist.Size = new System.Drawing.Size(80, 48);
            this.mnHist.TabIndex = 0;
            // 
            // históricosToolStripMenuItem
            // 
            this.históricosToolStripMenuItem.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.históricosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.entradasToolStripMenuItem,
            this.saídasToolStripMenuItem,
            this.atualizarToolStripMenuItem});
            this.históricosToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.históricosToolStripMenuItem.Name = "históricosToolStripMenuItem";
            this.históricosToolStripMenuItem.Size = new System.Drawing.Size(74, 44);
            this.históricosToolStripMenuItem.Text = "Históricos";
            // 
            // entradasToolStripMenuItem
            // 
            this.entradasToolStripMenuItem.Name = "entradasToolStripMenuItem";
            this.entradasToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.entradasToolStripMenuItem.Text = "Entradas";
            this.entradasToolStripMenuItem.Click += new System.EventHandler(this.entradasToolStripMenuItem_Click);
            // 
            // saídasToolStripMenuItem
            // 
            this.saídasToolStripMenuItem.Name = "saídasToolStripMenuItem";
            this.saídasToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.saídasToolStripMenuItem.Text = "Saídas";
            this.saídasToolStripMenuItem.Click += new System.EventHandler(this.saídasToolStripMenuItem_Click);
            // 
            // atualizarToolStripMenuItem
            // 
            this.atualizarToolStripMenuItem.Name = "atualizarToolStripMenuItem";
            this.atualizarToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.atualizarToolStripMenuItem.Text = "Atualizar";
            this.atualizarToolStripMenuItem.Click += new System.EventHandler(this.atualizarToolStripMenuItem_Click);
            // 
            // Histórico
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(590, 396);
            this.Controls.Add(this.dtgHist);
            this.Controls.Add(this.pnlHist);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Histórico";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Histórico";
            ((System.ComponentModel.ISupportInitialize)(this.dtgHist)).EndInit();
            this.pnlHist.ResumeLayout(false);
            this.mnHist.ResumeLayout(false);
            this.mnHist.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dtgHist;
        private System.Windows.Forms.Panel pnlHist;
        private System.Windows.Forms.MenuStrip mnHist;
        private System.Windows.Forms.ToolStripMenuItem históricosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem entradasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saídasToolStripMenuItem;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ToolStripMenuItem atualizarToolStripMenuItem;
    }
}