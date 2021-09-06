namespace SistemaEstoque
{
    partial class Faturamento
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtInserirDT = new System.Windows.Forms.TextBox();
            this.rdoInserirDT = new System.Windows.Forms.RadioButton();
            this.rdoDTAtual = new System.Windows.Forms.RadioButton();
            this.lblDate = new System.Windows.Forms.Label();
            this.dtgFatDiario = new System.Windows.Forms.DataGridView();
            this.btnFat = new System.Windows.Forms.Button();
            this.txtFatDiario = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.dtgFatMensal = new System.Windows.Forms.DataGridView();
            this.label4 = new System.Windows.Forms.Label();
            this.dtgFatAnual = new System.Windows.Forms.DataGridView();
            this.cboFatMensal = new System.Windows.Forms.ComboBox();
            this.cboFatAnual = new System.Windows.Forms.ComboBox();
            this.btnGerarMensal = new System.Windows.Forms.Button();
            this.btnGerarAnual = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.rdoInserirValorM = new System.Windows.Forms.RadioButton();
            this.txtInserirValorM = new System.Windows.Forms.TextBox();
            this.btnSalvarM = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnGerarF = new System.Windows.Forms.Button();
            this.rdoAll = new System.Windows.Forms.RadioButton();
            this.rdoAnual = new System.Windows.Forms.RadioButton();
            this.rdoMensal = new System.Windows.Forms.RadioButton();
            this.dtgFat = new System.Windows.Forms.DataGridView();
            this.btnSalvarA = new System.Windows.Forms.Button();
            this.txtInserirValorA = new System.Windows.Forms.TextBox();
            this.rdoInserirValorA = new System.Windows.Forms.RadioButton();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgFatDiario)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtgFatMensal)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtgFatAnual)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgFat)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.txtInserirDT);
            this.groupBox1.Controls.Add(this.rdoInserirDT);
            this.groupBox1.Controls.Add(this.rdoDTAtual);
            this.groupBox1.Controls.Add(this.lblDate);
            this.groupBox1.Controls.Add(this.dtgFatDiario);
            this.groupBox1.Controls.Add(this.btnFat);
            this.groupBox1.Controls.Add(this.txtFatDiario);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(14, 11);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(349, 341);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Faturamento Diário";
            // 
            // txtInserirDT
            // 
            this.txtInserirDT.Location = new System.Drawing.Point(157, 110);
            this.txtInserirDT.Name = "txtInserirDT";
            this.txtInserirDT.Size = new System.Drawing.Size(100, 26);
            this.txtInserirDT.TabIndex = 8;
            // 
            // rdoInserirDT
            // 
            this.rdoInserirDT.AutoSize = true;
            this.rdoInserirDT.Location = new System.Drawing.Point(35, 110);
            this.rdoInserirDT.Name = "rdoInserirDT";
            this.rdoInserirDT.Size = new System.Drawing.Size(124, 24);
            this.rdoInserirDT.TabIndex = 7;
            this.rdoInserirDT.TabStop = true;
            this.rdoInserirDT.Text = "Inserir data:";
            this.rdoInserirDT.UseVisualStyleBackColor = true;
            // 
            // rdoDTAtual
            // 
            this.rdoDTAtual.AutoSize = true;
            this.rdoDTAtual.Location = new System.Drawing.Point(35, 80);
            this.rdoDTAtual.Name = "rdoDTAtual";
            this.rdoDTAtual.Size = new System.Drawing.Size(116, 24);
            this.rdoDTAtual.TabIndex = 6;
            this.rdoDTAtual.TabStop = true;
            this.rdoDTAtual.Text = "Data atual:";
            this.rdoDTAtual.UseVisualStyleBackColor = true;
            // 
            // lblDate
            // 
            this.lblDate.AutoSize = true;
            this.lblDate.Location = new System.Drawing.Point(159, 82);
            this.lblDate.Name = "lblDate";
            this.lblDate.Size = new System.Drawing.Size(24, 20);
            this.lblDate.TabIndex = 4;
            this.lblDate.Text = "...";
            // 
            // dtgFatDiario
            // 
            this.dtgFatDiario.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgFatDiario.Location = new System.Drawing.Point(35, 175);
            this.dtgFatDiario.Name = "dtgFatDiario";
            this.dtgFatDiario.Size = new System.Drawing.Size(278, 146);
            this.dtgFatDiario.TabIndex = 3;
            // 
            // btnFat
            // 
            this.btnFat.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFat.Location = new System.Drawing.Point(263, 111);
            this.btnFat.Name = "btnFat";
            this.btnFat.Size = new System.Drawing.Size(75, 23);
            this.btnFat.TabIndex = 2;
            this.btnFat.Text = "Salvar";
            this.btnFat.UseVisualStyleBackColor = true;
            this.btnFat.Click += new System.EventHandler(this.btnFat_Click);
            // 
            // txtFatDiario
            // 
            this.txtFatDiario.Location = new System.Drawing.Point(256, 44);
            this.txtFatDiario.Name = "txtFatDiario";
            this.txtFatDiario.Size = new System.Drawing.Size(82, 26);
            this.txtFatDiario.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(24, 47);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(226, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Insira o faturamento diário:";
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(408, 28);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(47, 20);
            this.label3.TabIndex = 1;
            this.label3.Text = "Mês:";
            // 
            // dtgFatMensal
            // 
            this.dtgFatMensal.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.dtgFatMensal.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgFatMensal.Location = new System.Drawing.Point(412, 118);
            this.dtgFatMensal.Name = "dtgFatMensal";
            this.dtgFatMensal.Size = new System.Drawing.Size(306, 59);
            this.dtgFatMensal.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(411, 237);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(228, 20);
            this.label4.TabIndex = 5;
            this.label4.Text = "Faturamento ATUAL anual:";
            // 
            // dtgFatAnual
            // 
            this.dtgFatAnual.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.dtgFatAnual.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgFatAnual.Location = new System.Drawing.Point(412, 260);
            this.dtgFatAnual.Name = "dtgFatAnual";
            this.dtgFatAnual.Size = new System.Drawing.Size(306, 57);
            this.dtgFatAnual.TabIndex = 6;
            // 
            // cboFatMensal
            // 
            this.cboFatMensal.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.cboFatMensal.FormattingEnabled = true;
            this.cboFatMensal.Location = new System.Drawing.Point(461, 27);
            this.cboFatMensal.Name = "cboFatMensal";
            this.cboFatMensal.Size = new System.Drawing.Size(121, 21);
            this.cboFatMensal.TabIndex = 7;
            // 
            // cboFatAnual
            // 
            this.cboFatAnual.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.cboFatAnual.FormattingEnabled = true;
            this.cboFatAnual.Location = new System.Drawing.Point(461, 60);
            this.cboFatAnual.Name = "cboFatAnual";
            this.cboFatAnual.Size = new System.Drawing.Size(121, 21);
            this.cboFatAnual.TabIndex = 8;
            // 
            // btnGerarMensal
            // 
            this.btnGerarMensal.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnGerarMensal.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGerarMensal.Location = new System.Drawing.Point(647, 91);
            this.btnGerarMensal.Name = "btnGerarMensal";
            this.btnGerarMensal.Size = new System.Drawing.Size(71, 23);
            this.btnGerarMensal.TabIndex = 9;
            this.btnGerarMensal.Text = "Gerar";
            this.btnGerarMensal.UseVisualStyleBackColor = true;
            this.btnGerarMensal.Click += new System.EventHandler(this.btnGerarMensal_Click);
            // 
            // btnGerarAnual
            // 
            this.btnGerarAnual.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnGerarAnual.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGerarAnual.Location = new System.Drawing.Point(648, 234);
            this.btnGerarAnual.Name = "btnGerarAnual";
            this.btnGerarAnual.Size = new System.Drawing.Size(71, 23);
            this.btnGerarAnual.TabIndex = 10;
            this.btnGerarAnual.Text = "Gerar";
            this.btnGerarAnual.UseVisualStyleBackColor = true;
            this.btnGerarAnual.Click += new System.EventHandler(this.btnGerarAnual_Click);
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(411, 61);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(46, 20);
            this.label2.TabIndex = 11;
            this.label2.Text = "Ano:";
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(409, 97);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(223, 18);
            this.label5.TabIndex = 12;
            this.label5.Text = "Faturamento ATUAL mensal:";
            // 
            // rdoInserirValorM
            // 
            this.rdoInserirValorM.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.rdoInserirValorM.AutoSize = true;
            this.rdoInserirValorM.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdoInserirValorM.Location = new System.Drawing.Point(415, 182);
            this.rdoInserirValorM.Name = "rdoInserirValorM";
            this.rdoInserirValorM.Size = new System.Drawing.Size(148, 22);
            this.rdoInserirValorM.TabIndex = 13;
            this.rdoInserirValorM.TabStop = true;
            this.rdoInserirValorM.Text = "Inserir um valor:";
            this.rdoInserirValorM.UseVisualStyleBackColor = true;
            // 
            // txtInserirValorM
            // 
            this.txtInserirValorM.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.txtInserirValorM.Location = new System.Drawing.Point(566, 185);
            this.txtInserirValorM.Name = "txtInserirValorM";
            this.txtInserirValorM.Size = new System.Drawing.Size(60, 20);
            this.txtInserirValorM.TabIndex = 14;
            // 
            // btnSalvarM
            // 
            this.btnSalvarM.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnSalvarM.Location = new System.Drawing.Point(647, 183);
            this.btnSalvarM.Name = "btnSalvarM";
            this.btnSalvarM.Size = new System.Drawing.Size(71, 23);
            this.btnSalvarM.TabIndex = 15;
            this.btnSalvarM.Text = "Salvar";
            this.btnSalvarM.UseVisualStyleBackColor = true;
            this.btnSalvarM.Click += new System.EventHandler(this.btnSalvarM_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.groupBox2.Controls.Add(this.btnGerarF);
            this.groupBox2.Controls.Add(this.rdoAll);
            this.groupBox2.Controls.Add(this.rdoAnual);
            this.groupBox2.Controls.Add(this.rdoMensal);
            this.groupBox2.Controls.Add(this.dtgFat);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(14, 364);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(705, 220);
            this.groupBox2.TabIndex = 16;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Faturamentos Mensal e Anual";
            // 
            // btnGerarF
            // 
            this.btnGerarF.Location = new System.Drawing.Point(35, 147);
            this.btnGerarF.Name = "btnGerarF";
            this.btnGerarF.Size = new System.Drawing.Size(84, 32);
            this.btnGerarF.TabIndex = 4;
            this.btnGerarF.Text = "Gerar";
            this.btnGerarF.UseVisualStyleBackColor = true;
            this.btnGerarF.Click += new System.EventHandler(this.btnGerarF_Click);
            // 
            // rdoAll
            // 
            this.rdoAll.AutoSize = true;
            this.rdoAll.Location = new System.Drawing.Point(35, 108);
            this.rdoAll.Name = "rdoAll";
            this.rdoAll.Size = new System.Drawing.Size(76, 24);
            this.rdoAll.TabIndex = 3;
            this.rdoAll.TabStop = true;
            this.rdoAll.Text = "Todos";
            this.rdoAll.UseVisualStyleBackColor = true;
            // 
            // rdoAnual
            // 
            this.rdoAnual.AutoSize = true;
            this.rdoAnual.Location = new System.Drawing.Point(35, 78);
            this.rdoAnual.Name = "rdoAnual";
            this.rdoAnual.Size = new System.Drawing.Size(73, 24);
            this.rdoAnual.TabIndex = 2;
            this.rdoAnual.TabStop = true;
            this.rdoAnual.Text = "Anual";
            this.rdoAnual.UseVisualStyleBackColor = true;
            // 
            // rdoMensal
            // 
            this.rdoMensal.AutoSize = true;
            this.rdoMensal.Location = new System.Drawing.Point(35, 48);
            this.rdoMensal.Name = "rdoMensal";
            this.rdoMensal.Size = new System.Drawing.Size(84, 24);
            this.rdoMensal.TabIndex = 1;
            this.rdoMensal.TabStop = true;
            this.rdoMensal.Text = "Mensal";
            this.rdoMensal.UseVisualStyleBackColor = true;
            // 
            // dtgFat
            // 
            this.dtgFat.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgFat.Location = new System.Drawing.Point(232, 36);
            this.dtgFat.Name = "dtgFat";
            this.dtgFat.Size = new System.Drawing.Size(419, 157);
            this.dtgFat.TabIndex = 0;
            // 
            // btnSalvarA
            // 
            this.btnSalvarA.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnSalvarA.Location = new System.Drawing.Point(647, 324);
            this.btnSalvarA.Name = "btnSalvarA";
            this.btnSalvarA.Size = new System.Drawing.Size(71, 23);
            this.btnSalvarA.TabIndex = 19;
            this.btnSalvarA.Text = "Salvar";
            this.btnSalvarA.UseVisualStyleBackColor = true;
            this.btnSalvarA.Click += new System.EventHandler(this.btnSalvarA_Click);
            // 
            // txtInserirValorA
            // 
            this.txtInserirValorA.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.txtInserirValorA.Location = new System.Drawing.Point(566, 326);
            this.txtInserirValorA.Name = "txtInserirValorA";
            this.txtInserirValorA.Size = new System.Drawing.Size(60, 20);
            this.txtInserirValorA.TabIndex = 18;
            // 
            // rdoInserirValorA
            // 
            this.rdoInserirValorA.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.rdoInserirValorA.AutoSize = true;
            this.rdoInserirValorA.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdoInserirValorA.Location = new System.Drawing.Point(415, 323);
            this.rdoInserirValorA.Name = "rdoInserirValorA";
            this.rdoInserirValorA.Size = new System.Drawing.Size(148, 22);
            this.rdoInserirValorA.TabIndex = 17;
            this.rdoInserirValorA.TabStop = true;
            this.rdoInserirValorA.Text = "Inserir um valor:";
            this.rdoInserirValorA.UseVisualStyleBackColor = true;
            // 
            // Faturamento
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(744, 596);
            this.Controls.Add(this.btnSalvarA);
            this.Controls.Add(this.txtInserirValorA);
            this.Controls.Add(this.rdoInserirValorA);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.btnSalvarM);
            this.Controls.Add(this.txtInserirValorM);
            this.Controls.Add(this.rdoInserirValorM);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnGerarAnual);
            this.Controls.Add(this.btnGerarMensal);
            this.Controls.Add(this.cboFatAnual);
            this.Controls.Add(this.cboFatMensal);
            this.Controls.Add(this.dtgFatAnual);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.dtgFatMensal);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.groupBox1);
            this.Name = "Faturamento";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "                                                         ";
            this.Load += new System.EventHandler(this.Faturamento_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgFatDiario)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtgFatMensal)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtgFatAnual)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgFat)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dtgFatDiario;
        private System.Windows.Forms.Button btnFat;
        private System.Windows.Forms.TextBox txtFatDiario;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblDate;
        private System.Windows.Forms.TextBox txtInserirDT;
        private System.Windows.Forms.RadioButton rdoInserirDT;
        private System.Windows.Forms.RadioButton rdoDTAtual;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridView dtgFatMensal;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataGridView dtgFatAnual;
        private System.Windows.Forms.ComboBox cboFatMensal;
        private System.Windows.Forms.ComboBox cboFatAnual;
        private System.Windows.Forms.Button btnGerarMensal;
        private System.Windows.Forms.Button btnGerarAnual;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.RadioButton rdoInserirValorM;
        private System.Windows.Forms.TextBox txtInserirValorM;
        private System.Windows.Forms.Button btnSalvarM;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnGerarF;
        private System.Windows.Forms.RadioButton rdoAll;
        private System.Windows.Forms.RadioButton rdoAnual;
        private System.Windows.Forms.RadioButton rdoMensal;
        private System.Windows.Forms.DataGridView dtgFat;
        private System.Windows.Forms.Button btnSalvarA;
        private System.Windows.Forms.TextBox txtInserirValorA;
        private System.Windows.Forms.RadioButton rdoInserirValorA;
    }
}