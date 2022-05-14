namespace PTesteMetodo
{
    partial class frmExercicio2
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
            this.lblPalavra1 = new System.Windows.Forms.Label();
            this.lblPalavra2 = new System.Windows.Forms.Label();
            this.txtPalavra1 = new System.Windows.Forms.TextBox();
            this.txtPalavra2 = new System.Windows.Forms.TextBox();
            this.btnTestaIgual = new System.Windows.Forms.Button();
            this.btnInserirTexto1noTexto2 = new System.Windows.Forms.Button();
            this.btnInserirAsteriscoNaPalavra1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblPalavra1
            // 
            this.lblPalavra1.AutoSize = true;
            this.lblPalavra1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPalavra1.Location = new System.Drawing.Point(25, 28);
            this.lblPalavra1.Name = "lblPalavra1";
            this.lblPalavra1.Size = new System.Drawing.Size(68, 16);
            this.lblPalavra1.TabIndex = 0;
            this.lblPalavra1.Text = "Palavra 1:";
            // 
            // lblPalavra2
            // 
            this.lblPalavra2.AutoSize = true;
            this.lblPalavra2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPalavra2.Location = new System.Drawing.Point(25, 62);
            this.lblPalavra2.Name = "lblPalavra2";
            this.lblPalavra2.Size = new System.Drawing.Size(65, 16);
            this.lblPalavra2.TabIndex = 1;
            this.lblPalavra2.Text = "Palavra 2";
            // 
            // txtPalavra1
            // 
            this.txtPalavra1.Location = new System.Drawing.Point(112, 28);
            this.txtPalavra1.Name = "txtPalavra1";
            this.txtPalavra1.Size = new System.Drawing.Size(448, 20);
            this.txtPalavra1.TabIndex = 2;
            // 
            // txtPalavra2
            // 
            this.txtPalavra2.Location = new System.Drawing.Point(112, 62);
            this.txtPalavra2.Name = "txtPalavra2";
            this.txtPalavra2.Size = new System.Drawing.Size(448, 20);
            this.txtPalavra2.TabIndex = 3;
            // 
            // btnTestaIgual
            // 
            this.btnTestaIgual.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTestaIgual.Location = new System.Drawing.Point(28, 98);
            this.btnTestaIgual.Name = "btnTestaIgual";
            this.btnTestaIgual.Size = new System.Drawing.Size(155, 84);
            this.btnTestaIgual.TabIndex = 4;
            this.btnTestaIgual.Text = "Testar Iguais";
            this.btnTestaIgual.UseVisualStyleBackColor = true;
            this.btnTestaIgual.Click += new System.EventHandler(this.btnTestaIgual_Click);
            // 
            // btnInserirTexto1noTexto2
            // 
            this.btnInserirTexto1noTexto2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnInserirTexto1noTexto2.Location = new System.Drawing.Point(218, 98);
            this.btnInserirTexto1noTexto2.Name = "btnInserirTexto1noTexto2";
            this.btnInserirTexto1noTexto2.Size = new System.Drawing.Size(155, 84);
            this.btnInserirTexto1noTexto2.TabIndex = 5;
            this.btnInserirTexto1noTexto2.Text = "Inserir Texto 1 no Texto 2";
            this.btnInserirTexto1noTexto2.UseVisualStyleBackColor = true;
            this.btnInserirTexto1noTexto2.Click += new System.EventHandler(this.btnInserirTexto1noTexto2_Click);
            // 
            // btnInserirAsteriscoNaPalavra1
            // 
            this.btnInserirAsteriscoNaPalavra1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnInserirAsteriscoNaPalavra1.Location = new System.Drawing.Point(405, 98);
            this.btnInserirAsteriscoNaPalavra1.Name = "btnInserirAsteriscoNaPalavra1";
            this.btnInserirAsteriscoNaPalavra1.Size = new System.Drawing.Size(155, 84);
            this.btnInserirAsteriscoNaPalavra1.TabIndex = 6;
            this.btnInserirAsteriscoNaPalavra1.Text = "Inserir Asteriscos no Texto 1";
            this.btnInserirAsteriscoNaPalavra1.UseVisualStyleBackColor = true;
            this.btnInserirAsteriscoNaPalavra1.Click += new System.EventHandler(this.btnInserirAsteriscoNaPalavra1_Click);
            // 
            // frmExercicio2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(596, 213);
            this.Controls.Add(this.btnInserirAsteriscoNaPalavra1);
            this.Controls.Add(this.btnInserirTexto1noTexto2);
            this.Controls.Add(this.btnTestaIgual);
            this.Controls.Add(this.txtPalavra2);
            this.Controls.Add(this.txtPalavra1);
            this.Controls.Add(this.lblPalavra2);
            this.Controls.Add(this.lblPalavra1);
            this.Name = "frmExercicio2";
            this.Text = "Exercício 2";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblPalavra1;
        private System.Windows.Forms.Label lblPalavra2;
        private System.Windows.Forms.TextBox txtPalavra1;
        private System.Windows.Forms.TextBox txtPalavra2;
        private System.Windows.Forms.Button btnTestaIgual;
        private System.Windows.Forms.Button btnInserirTexto1noTexto2;
        private System.Windows.Forms.Button btnInserirAsteriscoNaPalavra1;
    }
}