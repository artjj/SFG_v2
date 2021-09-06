namespace ProjetoEstoque
{
    partial class Editar
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Editar));
            this.lblEditTt = new System.Windows.Forms.Label();
            this.txtEditCod = new System.Windows.Forms.TextBox();
            this.btnEditBuscar = new System.Windows.Forms.Button();
            this.lblEditDataVal = new System.Windows.Forms.Label();
            this.lblEditForn = new System.Windows.Forms.Label();
            this.lblEditDataFab = new System.Windows.Forms.Label();
            this.lblEditMarca = new System.Windows.Forms.Label();
            this.lblEditValorUnit = new System.Windows.Forms.Label();
            this.lblEditPrecoCompra = new System.Windows.Forms.Label();
            this.txtEditDataF = new System.Windows.Forms.TextBox();
            this.txtEditMarca = new System.Windows.Forms.TextBox();
            this.txtEditForn = new System.Windows.Forms.TextBox();
            this.txtEditDataV = new System.Windows.Forms.TextBox();
            this.txtEditValorUnit = new System.Windows.Forms.TextBox();
            this.txtEditTipo = new System.Windows.Forms.TextBox();
            this.btnEditNome = new System.Windows.Forms.Button();
            this.txtEditPrecoCompra = new System.Windows.Forms.TextBox();
            this.txtEditNome = new System.Windows.Forms.TextBox();
            this.lblEditNome = new System.Windows.Forms.Label();
            this.lblEditTipo = new System.Windows.Forms.Label();
            this.lblEditQtEst = new System.Windows.Forms.Label();
            this.gpbEdit = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnGerar = new System.Windows.Forms.Button();
            this.txtEditPercent = new System.Windows.Forms.TextBox();
            this.nmEditQtEst = new System.Windows.Forms.NumericUpDown();
            this.button1 = new System.Windows.Forms.Button();
            this.gpbEdit.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nmEditQtEst)).BeginInit();
            this.SuspendLayout();
            // 
            // lblEditTt
            // 
            this.lblEditTt.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblEditTt.AutoSize = true;
            this.lblEditTt.BackColor = System.Drawing.Color.Transparent;
            this.lblEditTt.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEditTt.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblEditTt.Location = new System.Drawing.Point(90, 55);
            this.lblEditTt.Name = "lblEditTt";
            this.lblEditTt.Size = new System.Drawing.Size(276, 25);
            this.lblEditTt.TabIndex = 7;
            this.lblEditTt.Text = "Digite o código do produto: ";
            // 
            // txtEditCod
            // 
            this.txtEditCod.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtEditCod.Location = new System.Drawing.Point(360, 57);
            this.txtEditCod.Name = "txtEditCod";
            this.txtEditCod.Size = new System.Drawing.Size(45, 29);
            this.txtEditCod.TabIndex = 8;
            // 
            // btnEditBuscar
            // 
            this.btnEditBuscar.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnEditBuscar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEditBuscar.Location = new System.Drawing.Point(411, 57);
            this.btnEditBuscar.Name = "btnEditBuscar";
            this.btnEditBuscar.Size = new System.Drawing.Size(48, 27);
            this.btnEditBuscar.TabIndex = 9;
            this.btnEditBuscar.Text = "Buscar";
            this.btnEditBuscar.UseVisualStyleBackColor = true;
            this.btnEditBuscar.Click += new System.EventHandler(this.btnEditLimpar_Click);
            // 
            // lblEditDataVal
            // 
            this.lblEditDataVal.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblEditDataVal.AutoSize = true;
            this.lblEditDataVal.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEditDataVal.Location = new System.Drawing.Point(90, 286);
            this.lblEditDataVal.Name = "lblEditDataVal";
            this.lblEditDataVal.Size = new System.Drawing.Size(183, 25);
            this.lblEditDataVal.TabIndex = 8;
            this.lblEditDataVal.Text = "Data de Validade:";
            // 
            // lblEditForn
            // 
            this.lblEditForn.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblEditForn.AutoSize = true;
            this.lblEditForn.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEditForn.Location = new System.Drawing.Point(90, 249);
            this.lblEditForn.Name = "lblEditForn";
            this.lblEditForn.Size = new System.Drawing.Size(128, 25);
            this.lblEditForn.TabIndex = 9;
            this.lblEditForn.Text = "Fornecedor:";
            // 
            // lblEditDataFab
            // 
            this.lblEditDataFab.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblEditDataFab.AutoSize = true;
            this.lblEditDataFab.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEditDataFab.Location = new System.Drawing.Point(90, 175);
            this.lblEditDataFab.Name = "lblEditDataFab";
            this.lblEditDataFab.Size = new System.Drawing.Size(125, 25);
            this.lblEditDataFab.TabIndex = 7;
            this.lblEditDataFab.Text = "Fabricação:";
            // 
            // lblEditMarca
            // 
            this.lblEditMarca.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblEditMarca.AutoSize = true;
            this.lblEditMarca.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEditMarca.Location = new System.Drawing.Point(90, 212);
            this.lblEditMarca.Name = "lblEditMarca";
            this.lblEditMarca.Size = new System.Drawing.Size(78, 25);
            this.lblEditMarca.TabIndex = 10;
            this.lblEditMarca.Text = "Marca:";
            // 
            // lblEditValorUnit
            // 
            this.lblEditValorUnit.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblEditValorUnit.AutoSize = true;
            this.lblEditValorUnit.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEditValorUnit.Location = new System.Drawing.Point(90, 399);
            this.lblEditValorUnit.Name = "lblEditValorUnit";
            this.lblEditValorUnit.Size = new System.Drawing.Size(163, 25);
            this.lblEditValorUnit.TabIndex = 11;
            this.lblEditValorUnit.Text = "Valor de venda:";
            // 
            // lblEditPrecoCompra
            // 
            this.lblEditPrecoCompra.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblEditPrecoCompra.AutoSize = true;
            this.lblEditPrecoCompra.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEditPrecoCompra.Location = new System.Drawing.Point(90, 322);
            this.lblEditPrecoCompra.Name = "lblEditPrecoCompra";
            this.lblEditPrecoCompra.Size = new System.Drawing.Size(185, 25);
            this.lblEditPrecoCompra.TabIndex = 12;
            this.lblEditPrecoCompra.Text = "Preço de Compra:";
            // 
            // txtEditDataF
            // 
            this.txtEditDataF.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtEditDataF.Location = new System.Drawing.Point(281, 173);
            this.txtEditDataF.Name = "txtEditDataF";
            this.txtEditDataF.Size = new System.Drawing.Size(124, 29);
            this.txtEditDataF.TabIndex = 13;
            // 
            // txtEditMarca
            // 
            this.txtEditMarca.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtEditMarca.Location = new System.Drawing.Point(281, 210);
            this.txtEditMarca.Name = "txtEditMarca";
            this.txtEditMarca.Size = new System.Drawing.Size(124, 29);
            this.txtEditMarca.TabIndex = 14;
            // 
            // txtEditForn
            // 
            this.txtEditForn.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtEditForn.Location = new System.Drawing.Point(281, 247);
            this.txtEditForn.Name = "txtEditForn";
            this.txtEditForn.Size = new System.Drawing.Size(124, 29);
            this.txtEditForn.TabIndex = 15;
            // 
            // txtEditDataV
            // 
            this.txtEditDataV.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtEditDataV.Location = new System.Drawing.Point(281, 284);
            this.txtEditDataV.Name = "txtEditDataV";
            this.txtEditDataV.Size = new System.Drawing.Size(124, 29);
            this.txtEditDataV.TabIndex = 16;
            // 
            // txtEditValorUnit
            // 
            this.txtEditValorUnit.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtEditValorUnit.Location = new System.Drawing.Point(259, 399);
            this.txtEditValorUnit.Name = "txtEditValorUnit";
            this.txtEditValorUnit.Size = new System.Drawing.Size(146, 29);
            this.txtEditValorUnit.TabIndex = 17;
            // 
            // txtEditTipo
            // 
            this.txtEditTipo.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtEditTipo.Location = new System.Drawing.Point(281, 136);
            this.txtEditTipo.Name = "txtEditTipo";
            this.txtEditTipo.Size = new System.Drawing.Size(124, 29);
            this.txtEditTipo.TabIndex = 4;
            // 
            // btnEditNome
            // 
            this.btnEditNome.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnEditNome.Image = ((System.Drawing.Image)(resources.GetObject("btnEditNome.Image")));
            this.btnEditNome.Location = new System.Drawing.Point(153, 521);
            this.btnEditNome.Name = "btnEditNome";
            this.btnEditNome.Size = new System.Drawing.Size(85, 61);
            this.btnEditNome.TabIndex = 1;
            this.btnEditNome.UseVisualStyleBackColor = true;
            this.btnEditNome.Click += new System.EventHandler(this.btnEditNome_Click);
            // 
            // txtEditPrecoCompra
            // 
            this.txtEditPrecoCompra.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtEditPrecoCompra.Location = new System.Drawing.Point(281, 322);
            this.txtEditPrecoCompra.Name = "txtEditPrecoCompra";
            this.txtEditPrecoCompra.Size = new System.Drawing.Size(124, 29);
            this.txtEditPrecoCompra.TabIndex = 18;
            // 
            // txtEditNome
            // 
            this.txtEditNome.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtEditNome.Location = new System.Drawing.Point(174, 94);
            this.txtEditNome.Name = "txtEditNome";
            this.txtEditNome.Size = new System.Drawing.Size(231, 29);
            this.txtEditNome.TabIndex = 2;
            // 
            // lblEditNome
            // 
            this.lblEditNome.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblEditNome.AutoSize = true;
            this.lblEditNome.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEditNome.Location = new System.Drawing.Point(90, 96);
            this.lblEditNome.Name = "lblEditNome";
            this.lblEditNome.Size = new System.Drawing.Size(74, 25);
            this.lblEditNome.TabIndex = 0;
            this.lblEditNome.Text = "Nome:";
            // 
            // lblEditTipo
            // 
            this.lblEditTipo.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblEditTipo.AutoSize = true;
            this.lblEditTipo.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEditTipo.Location = new System.Drawing.Point(90, 138);
            this.lblEditTipo.Name = "lblEditTipo";
            this.lblEditTipo.Size = new System.Drawing.Size(60, 25);
            this.lblEditTipo.TabIndex = 3;
            this.lblEditTipo.Text = "Tipo:";
            // 
            // lblEditQtEst
            // 
            this.lblEditQtEst.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblEditQtEst.AutoSize = true;
            this.lblEditQtEst.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEditQtEst.Location = new System.Drawing.Point(90, 443);
            this.lblEditQtEst.Name = "lblEditQtEst";
            this.lblEditQtEst.Size = new System.Drawing.Size(129, 25);
            this.lblEditQtEst.TabIndex = 25;
            this.lblEditQtEst.Text = "Quantidade:";
            // 
            // gpbEdit
            // 
            this.gpbEdit.BackColor = System.Drawing.Color.Transparent;
            this.gpbEdit.Controls.Add(this.btnEditBuscar);
            this.gpbEdit.Controls.Add(this.label1);
            this.gpbEdit.Controls.Add(this.txtEditCod);
            this.gpbEdit.Controls.Add(this.btnGerar);
            this.gpbEdit.Controls.Add(this.lblEditTt);
            this.gpbEdit.Controls.Add(this.txtEditPercent);
            this.gpbEdit.Controls.Add(this.nmEditQtEst);
            this.gpbEdit.Controls.Add(this.button1);
            this.gpbEdit.Controls.Add(this.lblEditQtEst);
            this.gpbEdit.Controls.Add(this.lblEditTipo);
            this.gpbEdit.Controls.Add(this.lblEditNome);
            this.gpbEdit.Controls.Add(this.txtEditNome);
            this.gpbEdit.Controls.Add(this.txtEditPrecoCompra);
            this.gpbEdit.Controls.Add(this.btnEditNome);
            this.gpbEdit.Controls.Add(this.txtEditTipo);
            this.gpbEdit.Controls.Add(this.txtEditValorUnit);
            this.gpbEdit.Controls.Add(this.txtEditDataV);
            this.gpbEdit.Controls.Add(this.txtEditForn);
            this.gpbEdit.Controls.Add(this.txtEditMarca);
            this.gpbEdit.Controls.Add(this.txtEditDataF);
            this.gpbEdit.Controls.Add(this.lblEditPrecoCompra);
            this.gpbEdit.Controls.Add(this.lblEditValorUnit);
            this.gpbEdit.Controls.Add(this.lblEditMarca);
            this.gpbEdit.Controls.Add(this.lblEditDataFab);
            this.gpbEdit.Controls.Add(this.lblEditForn);
            this.gpbEdit.Controls.Add(this.lblEditDataVal);
            this.gpbEdit.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gpbEdit.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gpbEdit.ForeColor = System.Drawing.SystemColors.ControlText;
            this.gpbEdit.Location = new System.Drawing.Point(0, 0);
            this.gpbEdit.Name = "gpbEdit";
            this.gpbEdit.Size = new System.Drawing.Size(562, 610);
            this.gpbEdit.TabIndex = 6;
            this.gpbEdit.TabStop = false;
            this.gpbEdit.Text = "Editar Produto";
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(90, 360);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(121, 25);
            this.label1.TabIndex = 35;
            this.label1.Text = "Percentual:";
            // 
            // btnGerar
            // 
            this.btnGerar.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnGerar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGerar.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnGerar.Location = new System.Drawing.Point(419, 399);
            this.btnGerar.Name = "btnGerar";
            this.btnGerar.Size = new System.Drawing.Size(79, 29);
            this.btnGerar.TabIndex = 34;
            this.btnGerar.Text = "Gerar";
            this.btnGerar.UseVisualStyleBackColor = true;
            this.btnGerar.Click += new System.EventHandler(this.btnGerar_Click);
            // 
            // txtEditPercent
            // 
            this.txtEditPercent.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtEditPercent.Location = new System.Drawing.Point(281, 360);
            this.txtEditPercent.Name = "txtEditPercent";
            this.txtEditPercent.Size = new System.Drawing.Size(124, 29);
            this.txtEditPercent.TabIndex = 33;
            // 
            // nmEditQtEst
            // 
            this.nmEditQtEst.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.nmEditQtEst.Location = new System.Drawing.Point(288, 443);
            this.nmEditQtEst.Name = "nmEditQtEst";
            this.nmEditQtEst.Size = new System.Drawing.Size(117, 29);
            this.nmEditQtEst.TabIndex = 30;
            // 
            // button1
            // 
            this.button1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.button1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.button1.Image = ((System.Drawing.Image)(resources.GetObject("button1.Image")));
            this.button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.Location = new System.Drawing.Point(281, 525);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(101, 54);
            this.button1.TabIndex = 29;
            this.button1.Text = "Fechar";
            this.button1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Editar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(562, 610);
            this.Controls.Add(this.gpbEdit);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Editar";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Editar";
            this.gpbEdit.ResumeLayout(false);
            this.gpbEdit.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nmEditQtEst)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label lblEditTt;
        private System.Windows.Forms.TextBox txtEditCod;
        private System.Windows.Forms.Button btnEditBuscar;
        private System.Windows.Forms.Label lblEditDataVal;
        private System.Windows.Forms.Label lblEditForn;
        private System.Windows.Forms.Label lblEditDataFab;
        private System.Windows.Forms.Label lblEditMarca;
        private System.Windows.Forms.Label lblEditValorUnit;
        private System.Windows.Forms.Label lblEditPrecoCompra;
        private System.Windows.Forms.TextBox txtEditDataF;
        private System.Windows.Forms.TextBox txtEditMarca;
        private System.Windows.Forms.TextBox txtEditForn;
        private System.Windows.Forms.TextBox txtEditDataV;
        private System.Windows.Forms.TextBox txtEditValorUnit;
        private System.Windows.Forms.TextBox txtEditTipo;
        private System.Windows.Forms.Button btnEditNome;
        private System.Windows.Forms.TextBox txtEditPrecoCompra;
        private System.Windows.Forms.TextBox txtEditNome;
        private System.Windows.Forms.Label lblEditNome;
        private System.Windows.Forms.Label lblEditTipo;
        private System.Windows.Forms.Label lblEditQtEst;
        private System.Windows.Forms.GroupBox gpbEdit;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.NumericUpDown nmEditQtEst;
        private System.Windows.Forms.TextBox txtEditPercent;
        private System.Windows.Forms.Button btnGerar;
        private System.Windows.Forms.Label label1;
    }
}