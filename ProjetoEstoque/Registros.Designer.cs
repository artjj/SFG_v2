namespace ProjetoEstoque
{
    partial class Registros
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Registros));
            this.lblRegCod = new System.Windows.Forms.Label();
            this.txtRegCod = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnRegCod = new System.Windows.Forms.Button();
            this.nmReg = new System.Windows.Forms.NumericUpDown();
            this.btnREG = new System.Windows.Forms.Button();
            this.gpReg = new System.Windows.Forms.GroupBox();
            this.txtNF = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.lblRegNome = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.nmReg)).BeginInit();
            this.gpReg.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblRegCod
            // 
            this.lblRegCod.AutoSize = true;
            this.lblRegCod.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRegCod.Location = new System.Drawing.Point(21, 37);
            this.lblRegCod.Name = "lblRegCod";
            this.lblRegCod.Size = new System.Drawing.Size(197, 25);
            this.lblRegCod.TabIndex = 0;
            this.lblRegCod.Text = "Código do Produto:";
            // 
            // txtRegCod
            // 
            this.txtRegCod.Location = new System.Drawing.Point(224, 34);
            this.txtRegCod.Name = "txtRegCod";
            this.txtRegCod.Size = new System.Drawing.Size(59, 31);
            this.txtRegCod.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(21, 184);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(137, 25);
            this.label1.TabIndex = 3;
            this.label1.Text = "Quantidade*:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(6, 243);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(297, 24);
            this.label2.TabIndex = 4;
            this.label2.Text = "*Quantidade de entrada OU saída!";
            // 
            // btnRegCod
            // 
            this.btnRegCod.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRegCod.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnRegCod.Location = new System.Drawing.Point(289, 33);
            this.btnRegCod.Name = "btnRegCod";
            this.btnRegCod.Size = new System.Drawing.Size(61, 32);
            this.btnRegCod.TabIndex = 5;
            this.btnRegCod.Text = "Buscar";
            this.btnRegCod.UseVisualStyleBackColor = true;
            this.btnRegCod.Click += new System.EventHandler(this.btnRegCod_Click);
            // 
            // nmReg
            // 
            this.nmReg.Location = new System.Drawing.Point(163, 182);
            this.nmReg.Name = "nmReg";
            this.nmReg.Size = new System.Drawing.Size(120, 31);
            this.nmReg.TabIndex = 6;
            // 
            // btnREG
            // 
            this.btnREG.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnREG.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnREG.Location = new System.Drawing.Point(290, 181);
            this.btnREG.Name = "btnREG";
            this.btnREG.Size = new System.Drawing.Size(70, 32);
            this.btnREG.TabIndex = 7;
            this.btnREG.Text = "Registrar";
            this.btnREG.UseVisualStyleBackColor = true;
            this.btnREG.Click += new System.EventHandler(this.btnREG_Click);
            // 
            // gpReg
            // 
            this.gpReg.BackColor = System.Drawing.Color.Transparent;
            this.gpReg.Controls.Add(this.txtNF);
            this.gpReg.Controls.Add(this.label3);
            this.gpReg.Controls.Add(this.lblRegNome);
            this.gpReg.Controls.Add(this.label2);
            this.gpReg.Controls.Add(this.nmReg);
            this.gpReg.Controls.Add(this.label1);
            this.gpReg.Controls.Add(this.btnREG);
            this.gpReg.Controls.Add(this.lblRegCod);
            this.gpReg.Controls.Add(this.txtRegCod);
            this.gpReg.Controls.Add(this.btnRegCod);
            this.gpReg.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gpReg.ForeColor = System.Drawing.SystemColors.ControlText;
            this.gpReg.Location = new System.Drawing.Point(12, 12);
            this.gpReg.Name = "gpReg";
            this.gpReg.Size = new System.Drawing.Size(486, 279);
            this.gpReg.TabIndex = 8;
            this.gpReg.TabStop = false;
            this.gpReg.Text = "Registrando:";
            // 
            // txtNF
            // 
            this.txtNF.BackColor = System.Drawing.SystemColors.Window;
            this.txtNF.Location = new System.Drawing.Point(163, 129);
            this.txtNF.Name = "txtNF";
            this.txtNF.Size = new System.Drawing.Size(120, 31);
            this.txtNF.TabIndex = 10;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(21, 129);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(126, 25);
            this.label3.TabIndex = 9;
            this.label3.Text = "Nota Fiscal:";
            // 
            // lblRegNome
            // 
            this.lblRegNome.AutoSize = true;
            this.lblRegNome.Location = new System.Drawing.Point(21, 80);
            this.lblRegNome.Name = "lblRegNome";
            this.lblRegNome.Size = new System.Drawing.Size(0, 25);
            this.lblRegNome.TabIndex = 8;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Image = ((System.Drawing.Image)(resources.GetObject("button1.Image")));
            this.button1.Location = new System.Drawing.Point(532, 274);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(110, 48);
            this.button1.TabIndex = 31;
            this.button1.Text = "Fechar";
            this.button1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Registros
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(654, 334);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.gpReg);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Registros";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Registros";
            ((System.ComponentModel.ISupportInitialize)(this.nmReg)).EndInit();
            this.gpReg.ResumeLayout(false);
            this.gpReg.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblRegCod;
        private System.Windows.Forms.TextBox txtRegCod;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnRegCod;
        private System.Windows.Forms.NumericUpDown nmReg;
        private System.Windows.Forms.Button btnREG;
        private System.Windows.Forms.GroupBox gpReg;
        private System.Windows.Forms.Label lblRegNome;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox txtNF;
        private System.Windows.Forms.Label label3;
    }
}