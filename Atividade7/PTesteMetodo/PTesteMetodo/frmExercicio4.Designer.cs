namespace PTesteMetodo
{
    partial class frmExercicio4
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
            this.rtbTexto = new System.Windows.Forms.RichTextBox();
            this.lblTexto = new System.Windows.Forms.Label();
            this.btnQuantasLetras = new System.Windows.Forms.Button();
            this.btnPrimeiroEspaco = new System.Windows.Forms.Button();
            this.btnQuantosNumeros = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // rtbTexto
            // 
            this.rtbTexto.Location = new System.Drawing.Point(109, 12);
            this.rtbTexto.Name = "rtbTexto";
            this.rtbTexto.Size = new System.Drawing.Size(372, 69);
            this.rtbTexto.TabIndex = 0;
            this.rtbTexto.Text = "";
            // 
            // lblTexto
            // 
            this.lblTexto.AutoSize = true;
            this.lblTexto.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTexto.Location = new System.Drawing.Point(29, 38);
            this.lblTexto.Name = "lblTexto";
            this.lblTexto.Size = new System.Drawing.Size(44, 16);
            this.lblTexto.TabIndex = 1;
            this.lblTexto.Text = "Texto:";
            // 
            // btnQuantasLetras
            // 
            this.btnQuantasLetras.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnQuantasLetras.Location = new System.Drawing.Point(344, 104);
            this.btnQuantasLetras.Name = "btnQuantasLetras";
            this.btnQuantasLetras.Size = new System.Drawing.Size(131, 84);
            this.btnQuantasLetras.TabIndex = 13;
            this.btnQuantasLetras.Text = "Quantas letras";
            this.btnQuantasLetras.UseVisualStyleBackColor = true;
            this.btnQuantasLetras.Click += new System.EventHandler(this.btnQuantasLetras_Click);
            // 
            // btnPrimeiroEspaco
            // 
            this.btnPrimeiroEspaco.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPrimeiroEspaco.Location = new System.Drawing.Point(195, 104);
            this.btnPrimeiroEspaco.Name = "btnPrimeiroEspaco";
            this.btnPrimeiroEspaco.Size = new System.Drawing.Size(131, 84);
            this.btnPrimeiroEspaco.TabIndex = 12;
            this.btnPrimeiroEspaco.Text = "Posição do primeiro espaço";
            this.btnPrimeiroEspaco.UseVisualStyleBackColor = true;
            this.btnPrimeiroEspaco.Click += new System.EventHandler(this.btnPrimeiroEspaco_Click);
            // 
            // btnQuantosNumeros
            // 
            this.btnQuantosNumeros.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnQuantosNumeros.Location = new System.Drawing.Point(39, 104);
            this.btnQuantosNumeros.Name = "btnQuantosNumeros";
            this.btnQuantosNumeros.Size = new System.Drawing.Size(131, 84);
            this.btnQuantosNumeros.TabIndex = 11;
            this.btnQuantosNumeros.Text = "Quantos números";
            this.btnQuantosNumeros.UseVisualStyleBackColor = true;
            this.btnQuantosNumeros.Click += new System.EventHandler(this.btnQuantosNumeros_Click);
            // 
            // frmExercicio4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(493, 222);
            this.Controls.Add(this.btnQuantasLetras);
            this.Controls.Add(this.btnPrimeiroEspaco);
            this.Controls.Add(this.btnQuantosNumeros);
            this.Controls.Add(this.lblTexto);
            this.Controls.Add(this.rtbTexto);
            this.Name = "frmExercicio4";
            this.Text = "Exercício 4";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox rtbTexto;
        private System.Windows.Forms.Label lblTexto;
        private System.Windows.Forms.Button btnQuantasLetras;
        private System.Windows.Forms.Button btnPrimeiroEspaco;
        private System.Windows.Forms.Button btnQuantosNumeros;
    }
}