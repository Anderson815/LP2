namespace Psalario
{
    partial class Form1
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
            this.txtNomeFuncionario = new System.Windows.Forms.TextBox();
            this.lblNomeFuncionario = new System.Windows.Forms.Label();
            this.lblAliquotaIRPF = new System.Windows.Forms.Label();
            this.lblSalarioFamilia = new System.Windows.Forms.Label();
            this.lblAliquotaINSS = new System.Windows.Forms.Label();
            this.lblDados = new System.Windows.Forms.Label();
            this.lblFilhos = new System.Windows.Forms.Label();
            this.lblSalario = new System.Windows.Forms.Label();
            this.lblSalarioLiquido = new System.Windows.Forms.Label();
            this.lblDescontoINSS = new System.Windows.Forms.Label();
            this.lblDescontoIRPF = new System.Windows.Forms.Label();
            this.btnVerificaDesconto = new System.Windows.Forms.Button();
            this.grpbxSexo = new System.Windows.Forms.GroupBox();
            this.rbtnMasculino = new System.Windows.Forms.RadioButton();
            this.rbtnFeminino = new System.Windows.Forms.RadioButton();
            this.chkbxCasado = new System.Windows.Forms.CheckBox();
            this.mskbxSalario = new System.Windows.Forms.MaskedTextBox();
            this.txtAliquotaINSS = new System.Windows.Forms.TextBox();
            this.txtDescontoIRPF = new System.Windows.Forms.TextBox();
            this.txtDescontoINSS = new System.Windows.Forms.TextBox();
            this.txtSalarioLiquido = new System.Windows.Forms.TextBox();
            this.txtSalarioFamilia = new System.Windows.Forms.TextBox();
            this.txtAliquotaIRPF = new System.Windows.Forms.TextBox();
            this.nudNumeroFilhos = new System.Windows.Forms.NumericUpDown();
            this.grpbxSexo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudNumeroFilhos)).BeginInit();
            this.SuspendLayout();
            // 
            // txtNomeFuncionario
            // 
            this.txtNomeFuncionario.Location = new System.Drawing.Point(180, 43);
            this.txtNomeFuncionario.Name = "txtNomeFuncionario";
            this.txtNomeFuncionario.Size = new System.Drawing.Size(182, 20);
            this.txtNomeFuncionario.TabIndex = 0;
            // 
            // lblNomeFuncionario
            // 
            this.lblNomeFuncionario.AutoSize = true;
            this.lblNomeFuncionario.Location = new System.Drawing.Point(47, 43);
            this.lblNomeFuncionario.Name = "lblNomeFuncionario";
            this.lblNomeFuncionario.Size = new System.Drawing.Size(93, 13);
            this.lblNomeFuncionario.TabIndex = 1;
            this.lblNomeFuncionario.Text = "Nome Funcionário";
            // 
            // lblAliquotaIRPF
            // 
            this.lblAliquotaIRPF.AutoSize = true;
            this.lblAliquotaIRPF.Location = new System.Drawing.Point(47, 272);
            this.lblAliquotaIRPF.Name = "lblAliquotaIRPF";
            this.lblAliquotaIRPF.Size = new System.Drawing.Size(72, 13);
            this.lblAliquotaIRPF.TabIndex = 2;
            this.lblAliquotaIRPF.Text = "Aliquota IRPF";
            // 
            // lblSalarioFamilia
            // 
            this.lblSalarioFamilia.AutoSize = true;
            this.lblSalarioFamilia.Location = new System.Drawing.Point(47, 302);
            this.lblSalarioFamilia.Name = "lblSalarioFamilia";
            this.lblSalarioFamilia.Size = new System.Drawing.Size(76, 13);
            this.lblSalarioFamilia.TabIndex = 3;
            this.lblSalarioFamilia.Text = "Salário Família";
            // 
            // lblAliquotaINSS
            // 
            this.lblAliquotaINSS.AutoSize = true;
            this.lblAliquotaINSS.Location = new System.Drawing.Point(47, 241);
            this.lblAliquotaINSS.Name = "lblAliquotaINSS";
            this.lblAliquotaINSS.Size = new System.Drawing.Size(73, 13);
            this.lblAliquotaINSS.TabIndex = 4;
            this.lblAliquotaINSS.Text = "Aliquota INSS";
            // 
            // lblDados
            // 
            this.lblDados.AutoSize = true;
            this.lblDados.Location = new System.Drawing.Point(47, 193);
            this.lblDados.Name = "lblDados";
            this.lblDados.Size = new System.Drawing.Size(52, 13);
            this.lblDados.TabIndex = 5;
            this.lblDados.Text = "LblDados";
            // 
            // lblFilhos
            // 
            this.lblFilhos.AutoSize = true;
            this.lblFilhos.Location = new System.Drawing.Point(47, 105);
            this.lblFilhos.Name = "lblFilhos";
            this.lblFilhos.Size = new System.Drawing.Size(89, 13);
            this.lblFilhos.TabIndex = 6;
            this.lblFilhos.Text = "Numero de Filhos";
            // 
            // lblSalario
            // 
            this.lblSalario.AutoSize = true;
            this.lblSalario.Location = new System.Drawing.Point(47, 74);
            this.lblSalario.Name = "lblSalario";
            this.lblSalario.Size = new System.Drawing.Size(67, 13);
            this.lblSalario.TabIndex = 7;
            this.lblSalario.Text = "Salário Bruto";
            // 
            // lblSalarioLiquido
            // 
            this.lblSalarioLiquido.AutoSize = true;
            this.lblSalarioLiquido.Location = new System.Drawing.Point(47, 332);
            this.lblSalarioLiquido.Name = "lblSalarioLiquido";
            this.lblSalarioLiquido.Size = new System.Drawing.Size(78, 13);
            this.lblSalarioLiquido.TabIndex = 8;
            this.lblSalarioLiquido.Text = "Salário Líquido";
            // 
            // lblDescontoINSS
            // 
            this.lblDescontoINSS.AutoSize = true;
            this.lblDescontoINSS.Location = new System.Drawing.Point(441, 241);
            this.lblDescontoINSS.Name = "lblDescontoINSS";
            this.lblDescontoINSS.Size = new System.Drawing.Size(81, 13);
            this.lblDescontoINSS.TabIndex = 9;
            this.lblDescontoINSS.Text = "Desconto INSS";
            // 
            // lblDescontoIRPF
            // 
            this.lblDescontoIRPF.AutoSize = true;
            this.lblDescontoIRPF.Location = new System.Drawing.Point(441, 269);
            this.lblDescontoIRPF.Name = "lblDescontoIRPF";
            this.lblDescontoIRPF.Size = new System.Drawing.Size(80, 13);
            this.lblDescontoIRPF.TabIndex = 10;
            this.lblDescontoIRPF.Text = "Desconto IRPF";
            // 
            // btnVerificaDesconto
            // 
            this.btnVerificaDesconto.Location = new System.Drawing.Point(50, 135);
            this.btnVerificaDesconto.Name = "btnVerificaDesconto";
            this.btnVerificaDesconto.Size = new System.Drawing.Size(312, 23);
            this.btnVerificaDesconto.TabIndex = 11;
            this.btnVerificaDesconto.Text = "Verifica Desconto";
            this.btnVerificaDesconto.UseVisualStyleBackColor = true;
            this.btnVerificaDesconto.Click += new System.EventHandler(this.btnVerificaDesconto_Click);
            // 
            // grpbxSexo
            // 
            this.grpbxSexo.Controls.Add(this.rbtnMasculino);
            this.grpbxSexo.Controls.Add(this.rbtnFeminino);
            this.grpbxSexo.Location = new System.Drawing.Point(532, 43);
            this.grpbxSexo.Name = "grpbxSexo";
            this.grpbxSexo.Size = new System.Drawing.Size(200, 100);
            this.grpbxSexo.TabIndex = 12;
            this.grpbxSexo.TabStop = false;
            this.grpbxSexo.Text = "Sexo";
            // 
            // rbtnMasculino
            // 
            this.rbtnMasculino.AutoSize = true;
            this.rbtnMasculino.Location = new System.Drawing.Point(22, 58);
            this.rbtnMasculino.Name = "rbtnMasculino";
            this.rbtnMasculino.Size = new System.Drawing.Size(73, 17);
            this.rbtnMasculino.TabIndex = 1;
            this.rbtnMasculino.Text = "Masculino";
            this.rbtnMasculino.UseVisualStyleBackColor = true;
            // 
            // rbtnFeminino
            // 
            this.rbtnFeminino.AutoSize = true;
            this.rbtnFeminino.Checked = true;
            this.rbtnFeminino.Location = new System.Drawing.Point(22, 26);
            this.rbtnFeminino.Name = "rbtnFeminino";
            this.rbtnFeminino.Size = new System.Drawing.Size(67, 17);
            this.rbtnFeminino.TabIndex = 0;
            this.rbtnFeminino.TabStop = true;
            this.rbtnFeminino.Text = "Feminino";
            this.rbtnFeminino.UseVisualStyleBackColor = true;
            // 
            // chkbxCasado
            // 
            this.chkbxCasado.AutoSize = true;
            this.chkbxCasado.Location = new System.Drawing.Point(532, 160);
            this.chkbxCasado.Name = "chkbxCasado";
            this.chkbxCasado.Size = new System.Drawing.Size(62, 17);
            this.chkbxCasado.TabIndex = 13;
            this.chkbxCasado.Text = "Casado";
            this.chkbxCasado.UseVisualStyleBackColor = true;
            // 
            // mskbxSalario
            // 
            this.mskbxSalario.Location = new System.Drawing.Point(180, 74);
            this.mskbxSalario.Mask = "99000.00";
            this.mskbxSalario.Name = "mskbxSalario";
            this.mskbxSalario.Size = new System.Drawing.Size(182, 20);
            this.mskbxSalario.TabIndex = 14;
            // 
            // txtAliquotaINSS
            // 
            this.txtAliquotaINSS.Enabled = false;
            this.txtAliquotaINSS.Location = new System.Drawing.Point(148, 241);
            this.txtAliquotaINSS.Name = "txtAliquotaINSS";
            this.txtAliquotaINSS.Size = new System.Drawing.Size(182, 20);
            this.txtAliquotaINSS.TabIndex = 15;
            // 
            // txtDescontoIRPF
            // 
            this.txtDescontoIRPF.Enabled = false;
            this.txtDescontoIRPF.Location = new System.Drawing.Point(532, 269);
            this.txtDescontoIRPF.Name = "txtDescontoIRPF";
            this.txtDescontoIRPF.Size = new System.Drawing.Size(182, 20);
            this.txtDescontoIRPF.TabIndex = 16;
            // 
            // txtDescontoINSS
            // 
            this.txtDescontoINSS.Enabled = false;
            this.txtDescontoINSS.Location = new System.Drawing.Point(532, 238);
            this.txtDescontoINSS.Name = "txtDescontoINSS";
            this.txtDescontoINSS.Size = new System.Drawing.Size(182, 20);
            this.txtDescontoINSS.TabIndex = 17;
            // 
            // txtSalarioLiquido
            // 
            this.txtSalarioLiquido.Enabled = false;
            this.txtSalarioLiquido.Location = new System.Drawing.Point(148, 332);
            this.txtSalarioLiquido.Name = "txtSalarioLiquido";
            this.txtSalarioLiquido.Size = new System.Drawing.Size(182, 20);
            this.txtSalarioLiquido.TabIndex = 18;
            // 
            // txtSalarioFamilia
            // 
            this.txtSalarioFamilia.Enabled = false;
            this.txtSalarioFamilia.Location = new System.Drawing.Point(148, 302);
            this.txtSalarioFamilia.Name = "txtSalarioFamilia";
            this.txtSalarioFamilia.Size = new System.Drawing.Size(182, 20);
            this.txtSalarioFamilia.TabIndex = 19;
            // 
            // txtAliquotaIRPF
            // 
            this.txtAliquotaIRPF.Enabled = false;
            this.txtAliquotaIRPF.Location = new System.Drawing.Point(148, 272);
            this.txtAliquotaIRPF.Name = "txtAliquotaIRPF";
            this.txtAliquotaIRPF.Size = new System.Drawing.Size(182, 20);
            this.txtAliquotaIRPF.TabIndex = 20;
            // 
            // nudNumeroFilhos
            // 
            this.nudNumeroFilhos.Location = new System.Drawing.Point(180, 101);
            this.nudNumeroFilhos.Maximum = new decimal(new int[] {
            20,
            0,
            0,
            0});
            this.nudNumeroFilhos.Name = "nudNumeroFilhos";
            this.nudNumeroFilhos.ReadOnly = true;
            this.nudNumeroFilhos.Size = new System.Drawing.Size(182, 20);
            this.nudNumeroFilhos.TabIndex = 21;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(764, 377);
            this.Controls.Add(this.nudNumeroFilhos);
            this.Controls.Add(this.txtAliquotaIRPF);
            this.Controls.Add(this.txtSalarioFamilia);
            this.Controls.Add(this.txtSalarioLiquido);
            this.Controls.Add(this.txtDescontoINSS);
            this.Controls.Add(this.txtDescontoIRPF);
            this.Controls.Add(this.txtAliquotaINSS);
            this.Controls.Add(this.mskbxSalario);
            this.Controls.Add(this.chkbxCasado);
            this.Controls.Add(this.grpbxSexo);
            this.Controls.Add(this.btnVerificaDesconto);
            this.Controls.Add(this.lblDescontoIRPF);
            this.Controls.Add(this.lblDescontoINSS);
            this.Controls.Add(this.lblSalarioLiquido);
            this.Controls.Add(this.lblSalario);
            this.Controls.Add(this.lblFilhos);
            this.Controls.Add(this.lblDados);
            this.Controls.Add(this.lblAliquotaINSS);
            this.Controls.Add(this.lblSalarioFamilia);
            this.Controls.Add(this.lblAliquotaIRPF);
            this.Controls.Add(this.lblNomeFuncionario);
            this.Controls.Add(this.txtNomeFuncionario);
            this.Name = "Form1";
            this.Text = "Salário";
            this.grpbxSexo.ResumeLayout(false);
            this.grpbxSexo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudNumeroFilhos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtNomeFuncionario;
        private System.Windows.Forms.Label lblNomeFuncionario;
        private System.Windows.Forms.Label lblAliquotaIRPF;
        private System.Windows.Forms.Label lblSalarioFamilia;
        private System.Windows.Forms.Label lblAliquotaINSS;
        private System.Windows.Forms.Label lblDados;
        private System.Windows.Forms.Label lblFilhos;
        private System.Windows.Forms.Label lblSalario;
        private System.Windows.Forms.Label lblSalarioLiquido;
        private System.Windows.Forms.Label lblDescontoINSS;
        private System.Windows.Forms.Label lblDescontoIRPF;
        private System.Windows.Forms.Button btnVerificaDesconto;
        private System.Windows.Forms.GroupBox grpbxSexo;
        private System.Windows.Forms.RadioButton rbtnMasculino;
        private System.Windows.Forms.RadioButton rbtnFeminino;
        private System.Windows.Forms.CheckBox chkbxCasado;
        private System.Windows.Forms.MaskedTextBox mskbxSalario;
        private System.Windows.Forms.TextBox txtAliquotaINSS;
        private System.Windows.Forms.TextBox txtDescontoIRPF;
        private System.Windows.Forms.TextBox txtDescontoINSS;
        private System.Windows.Forms.TextBox txtSalarioLiquido;
        private System.Windows.Forms.TextBox txtSalarioFamilia;
        private System.Windows.Forms.TextBox txtAliquotaIRPF;
        private System.Windows.Forms.NumericUpDown nudNumeroFilhos;
    }
}

