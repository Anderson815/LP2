namespace PTesteEventos
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
            this.label1 = new System.Windows.Forms.Label();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtEndereco = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.mskDataVencimento = new System.Windows.Forms.MaskedTextBox();
            this.mskValor = new System.Windows.Forms.MaskedTextBox();
            this.btnEnviar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(34, 31);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(104, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nome Cliente";
            // 
            // txtNome
            // 
            this.txtNome.Location = new System.Drawing.Point(200, 31);
            this.txtNome.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(199, 26);
            this.txtNome.TabIndex = 1;
            this.txtNome.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNome_KeyPress);
            this.txtNome.Leave += new System.EventHandler(this.txtNome_Leave);
            this.txtNome.Validated += new System.EventHandler(this.txtNome_Validated);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(34, 82);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(78, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "Endereço";
            // 
            // txtEndereco
            // 
            this.txtEndereco.Location = new System.Drawing.Point(200, 82);
            this.txtEndereco.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtEndereco.Name = "txtEndereco";
            this.txtEndereco.Size = new System.Drawing.Size(199, 26);
            this.txtEndereco.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(34, 137);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(155, 20);
            this.label3.TabIndex = 4;
            this.label3.Text = "Data de Vencimento";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(34, 189);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(46, 20);
            this.label4.TabIndex = 5;
            this.label4.Text = "Valor";
            // 
            // mskDataVencimento
            // 
            this.mskDataVencimento.Location = new System.Drawing.Point(200, 134);
            this.mskDataVencimento.Mask = "00/00/0000";
            this.mskDataVencimento.Name = "mskDataVencimento";
            this.mskDataVencimento.Size = new System.Drawing.Size(84, 26);
            this.mskDataVencimento.TabIndex = 6;
            this.mskDataVencimento.Validating += new System.ComponentModel.CancelEventHandler(this.mskDataVencimento_Validating);
            // 
            // mskValor
            // 
            this.mskValor.Location = new System.Drawing.Point(200, 186);
            this.mskValor.Mask = "999990.00";
            this.mskValor.Name = "mskValor";
            this.mskValor.Size = new System.Drawing.Size(84, 26);
            this.mskValor.TabIndex = 7;
            this.mskValor.Validated += new System.EventHandler(this.mskValor_Validated);
            // 
            // btnEnviar
            // 
            this.btnEnviar.Location = new System.Drawing.Point(38, 249);
            this.btnEnviar.Name = "btnEnviar";
            this.btnEnviar.Size = new System.Drawing.Size(361, 60);
            this.btnEnviar.TabIndex = 8;
            this.btnEnviar.Text = "Enviar Dados";
            this.btnEnviar.UseVisualStyleBackColor = true;
            this.btnEnviar.Click += new System.EventHandler(this.btnEnviar_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(443, 329);
            this.Controls.Add(this.btnEnviar);
            this.Controls.Add(this.mskValor);
            this.Controls.Add(this.mskDataVencimento);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtEndereco);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtNome);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Form1";
            this.Text = "Cadastro de Boleto";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtEndereco;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.MaskedTextBox mskDataVencimento;
        private System.Windows.Forms.MaskedTextBox mskValor;
        private System.Windows.Forms.Button btnEnviar;
    }
}

