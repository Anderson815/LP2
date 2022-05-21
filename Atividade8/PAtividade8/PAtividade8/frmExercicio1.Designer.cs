namespace PAtividade8
{
    partial class frmExercicio1
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
            this.btnEspacoBranco = new System.Windows.Forms.Button();
            this.btnNumerosR = new System.Windows.Forms.Button();
            this.btnParesLetras = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // rtbTexto
            // 
            this.rtbTexto.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rtbTexto.Location = new System.Drawing.Point(124, 24);
            this.rtbTexto.MaxLength = 100;
            this.rtbTexto.Name = "rtbTexto";
            this.rtbTexto.Size = new System.Drawing.Size(431, 96);
            this.rtbTexto.TabIndex = 0;
            this.rtbTexto.Text = "";
            // 
            // lblTexto
            // 
            this.lblTexto.AutoSize = true;
            this.lblTexto.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTexto.Location = new System.Drawing.Point(36, 55);
            this.lblTexto.Name = "lblTexto";
            this.lblTexto.Size = new System.Drawing.Size(72, 25);
            this.lblTexto.TabIndex = 1;
            this.lblTexto.Text = "Texto:";
            // 
            // btnEspacoBranco
            // 
            this.btnEspacoBranco.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEspacoBranco.Location = new System.Drawing.Point(41, 140);
            this.btnEspacoBranco.Name = "btnEspacoBranco";
            this.btnEspacoBranco.Size = new System.Drawing.Size(160, 74);
            this.btnEspacoBranco.TabIndex = 2;
            this.btnEspacoBranco.Text = "Qtde. Espaço em branco";
            this.btnEspacoBranco.UseVisualStyleBackColor = true;
            this.btnEspacoBranco.Click += new System.EventHandler(this.btnEspacoBranco_Click);
            // 
            // btnNumerosR
            // 
            this.btnNumerosR.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNumerosR.Location = new System.Drawing.Point(218, 140);
            this.btnNumerosR.Name = "btnNumerosR";
            this.btnNumerosR.Size = new System.Drawing.Size(160, 74);
            this.btnNumerosR.TabIndex = 3;
            this.btnNumerosR.Text = "Qtde. Letras Rs";
            this.btnNumerosR.UseVisualStyleBackColor = true;
            this.btnNumerosR.Click += new System.EventHandler(this.btnNumerosR_Click);
            // 
            // btnParesLetras
            // 
            this.btnParesLetras.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnParesLetras.Location = new System.Drawing.Point(395, 140);
            this.btnParesLetras.Name = "btnParesLetras";
            this.btnParesLetras.Size = new System.Drawing.Size(160, 74);
            this.btnParesLetras.TabIndex = 4;
            this.btnParesLetras.Text = "Qtde. de Pares de letras";
            this.btnParesLetras.UseVisualStyleBackColor = true;
            this.btnParesLetras.Click += new System.EventHandler(this.btnParesLetras_Click);
            // 
            // frmExercicio1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(589, 226);
            this.Controls.Add(this.btnParesLetras);
            this.Controls.Add(this.btnNumerosR);
            this.Controls.Add(this.btnEspacoBranco);
            this.Controls.Add(this.lblTexto);
            this.Controls.Add(this.rtbTexto);
            this.Name = "frmExercicio1";
            this.Text = "frmExercicio1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox rtbTexto;
        private System.Windows.Forms.Label lblTexto;
        private System.Windows.Forms.Button btnEspacoBranco;
        private System.Windows.Forms.Button btnNumerosR;
        private System.Windows.Forms.Button btnParesLetras;
    }
}