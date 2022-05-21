namespace PAtividade8
{
    partial class frmExercicio3
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
            this.btnVerificarPalindromo = new System.Windows.Forms.Button();
            this.lblTexto = new System.Windows.Forms.Label();
            this.txtTexto = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnVerificarPalindromo
            // 
            this.btnVerificarPalindromo.Location = new System.Drawing.Point(42, 108);
            this.btnVerificarPalindromo.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnVerificarPalindromo.Name = "btnVerificarPalindromo";
            this.btnVerificarPalindromo.Size = new System.Drawing.Size(397, 87);
            this.btnVerificarPalindromo.TabIndex = 5;
            this.btnVerificarPalindromo.Text = "Verificar se é palíndromo";
            this.btnVerificarPalindromo.UseVisualStyleBackColor = true;
            this.btnVerificarPalindromo.Click += new System.EventHandler(this.btnVerificarPalindromo_Click);
            // 
            // lblTexto
            // 
            this.lblTexto.AutoSize = true;
            this.lblTexto.Location = new System.Drawing.Point(38, 48);
            this.lblTexto.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblTexto.Name = "lblTexto";
            this.lblTexto.Size = new System.Drawing.Size(137, 20);
            this.lblTexto.TabIndex = 4;
            this.lblTexto.Text = "Informe um texto: ";
            // 
            // txtTexto
            // 
            this.txtTexto.Location = new System.Drawing.Point(206, 48);
            this.txtTexto.Margin = new System.Windows.Forms.Padding(6, 8, 6, 8);
            this.txtTexto.MaxLength = 50;
            this.txtTexto.Name = "txtTexto";
            this.txtTexto.Size = new System.Drawing.Size(233, 26);
            this.txtTexto.TabIndex = 3;
            // 
            // frmExercicio3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(487, 229);
            this.Controls.Add(this.btnVerificarPalindromo);
            this.Controls.Add(this.lblTexto);
            this.Controls.Add(this.txtTexto);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "frmExercicio3";
            this.Text = "frmExercicio3";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnVerificarPalindromo;
        private System.Windows.Forms.Label lblTexto;
        private System.Windows.Forms.TextBox txtTexto;
    }
}