namespace PTesteMetodo
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
            this.txtPalavra2 = new System.Windows.Forms.TextBox();
            this.txtPalavra1 = new System.Windows.Forms.TextBox();
            this.lblPalavra2 = new System.Windows.Forms.Label();
            this.lblPalavra1 = new System.Windows.Forms.Label();
            this.btnInverteReverse = new System.Windows.Forms.Button();
            this.btnRemoveOcorrenciaReplace = new System.Windows.Forms.Button();
            this.btnRemoveOcorrencia = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtPalavra2
            // 
            this.txtPalavra2.Location = new System.Drawing.Point(130, 69);
            this.txtPalavra2.Name = "txtPalavra2";
            this.txtPalavra2.Size = new System.Drawing.Size(448, 20);
            this.txtPalavra2.TabIndex = 7;
            // 
            // txtPalavra1
            // 
            this.txtPalavra1.Location = new System.Drawing.Point(130, 35);
            this.txtPalavra1.Name = "txtPalavra1";
            this.txtPalavra1.Size = new System.Drawing.Size(448, 20);
            this.txtPalavra1.TabIndex = 6;
            // 
            // lblPalavra2
            // 
            this.lblPalavra2.AutoSize = true;
            this.lblPalavra2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPalavra2.Location = new System.Drawing.Point(43, 69);
            this.lblPalavra2.Name = "lblPalavra2";
            this.lblPalavra2.Size = new System.Drawing.Size(65, 16);
            this.lblPalavra2.TabIndex = 5;
            this.lblPalavra2.Text = "Palavra 2";
            // 
            // lblPalavra1
            // 
            this.lblPalavra1.AutoSize = true;
            this.lblPalavra1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPalavra1.Location = new System.Drawing.Point(43, 35);
            this.lblPalavra1.Name = "lblPalavra1";
            this.lblPalavra1.Size = new System.Drawing.Size(68, 16);
            this.lblPalavra1.TabIndex = 4;
            this.lblPalavra1.Text = "Palavra 1:";
            // 
            // btnInverteReverse
            // 
            this.btnInverteReverse.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnInverteReverse.Location = new System.Drawing.Point(423, 116);
            this.btnInverteReverse.Name = "btnInverteReverse";
            this.btnInverteReverse.Size = new System.Drawing.Size(155, 84);
            this.btnInverteReverse.TabIndex = 10;
            this.btnInverteReverse.Text = "Inverte (Reverse)";
            this.btnInverteReverse.UseVisualStyleBackColor = true;
            this.btnInverteReverse.Click += new System.EventHandler(this.btnInverteReverse_Click);
            // 
            // btnRemoveOcorrenciaReplace
            // 
            this.btnRemoveOcorrenciaReplace.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRemoveOcorrenciaReplace.Location = new System.Drawing.Point(236, 116);
            this.btnRemoveOcorrenciaReplace.Name = "btnRemoveOcorrenciaReplace";
            this.btnRemoveOcorrenciaReplace.Size = new System.Drawing.Size(155, 84);
            this.btnRemoveOcorrenciaReplace.TabIndex = 9;
            this.btnRemoveOcorrenciaReplace.Text = "Remove Ocorrência (Replace)";
            this.btnRemoveOcorrenciaReplace.UseVisualStyleBackColor = true;
            this.btnRemoveOcorrenciaReplace.Click += new System.EventHandler(this.btnRemoveOcorrenciaReplace_Click);
            // 
            // btnRemoveOcorrencia
            // 
            this.btnRemoveOcorrencia.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRemoveOcorrencia.Location = new System.Drawing.Point(46, 116);
            this.btnRemoveOcorrencia.Name = "btnRemoveOcorrencia";
            this.btnRemoveOcorrencia.Size = new System.Drawing.Size(155, 84);
            this.btnRemoveOcorrencia.TabIndex = 8;
            this.btnRemoveOcorrencia.Text = "Remover Ocorrência";
            this.btnRemoveOcorrencia.UseVisualStyleBackColor = true;
            this.btnRemoveOcorrencia.Click += new System.EventHandler(this.btnRemoveOcorrencia_Click);
            // 
            // frmExercicio3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(627, 249);
            this.Controls.Add(this.btnInverteReverse);
            this.Controls.Add(this.btnRemoveOcorrenciaReplace);
            this.Controls.Add(this.btnRemoveOcorrencia);
            this.Controls.Add(this.txtPalavra2);
            this.Controls.Add(this.txtPalavra1);
            this.Controls.Add(this.lblPalavra2);
            this.Controls.Add(this.lblPalavra1);
            this.Name = "frmExercicio3";
            this.Text = "Exercício 3";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtPalavra2;
        private System.Windows.Forms.TextBox txtPalavra1;
        private System.Windows.Forms.Label lblPalavra2;
        private System.Windows.Forms.Label lblPalavra1;
        private System.Windows.Forms.Button btnInverteReverse;
        private System.Windows.Forms.Button btnRemoveOcorrenciaReplace;
        private System.Windows.Forms.Button btnRemoveOcorrencia;
    }
}