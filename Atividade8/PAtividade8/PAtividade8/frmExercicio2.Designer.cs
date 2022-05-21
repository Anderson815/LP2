namespace PAtividade8
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
            this.txtN = new System.Windows.Forms.TextBox();
            this.lblNumero = new System.Windows.Forms.Label();
            this.btnGerarNumeroH = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtN
            // 
            this.txtN.Location = new System.Drawing.Point(208, 31);
            this.txtN.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtN.Name = "txtN";
            this.txtN.Size = new System.Drawing.Size(148, 26);
            this.txtN.TabIndex = 0;
            // 
            // lblNumero
            // 
            this.lblNumero.AutoSize = true;
            this.lblNumero.Location = new System.Drawing.Point(28, 31);
            this.lblNumero.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblNumero.Name = "lblNumero";
            this.lblNumero.Size = new System.Drawing.Size(156, 20);
            this.lblNumero.TabIndex = 1;
            this.lblNumero.Text = "Informe um número: ";
            // 
            // btnGerarNumeroH
            // 
            this.btnGerarNumeroH.Location = new System.Drawing.Point(32, 81);
            this.btnGerarNumeroH.Name = "btnGerarNumeroH";
            this.btnGerarNumeroH.Size = new System.Drawing.Size(324, 65);
            this.btnGerarNumeroH.TabIndex = 2;
            this.btnGerarNumeroH.Text = "Gerar número H";
            this.btnGerarNumeroH.UseVisualStyleBackColor = true;
            this.btnGerarNumeroH.Click += new System.EventHandler(this.btnGerarNumeroH_Click);
            // 
            // frmExercicio2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(382, 180);
            this.Controls.Add(this.btnGerarNumeroH);
            this.Controls.Add(this.lblNumero);
            this.Controls.Add(this.txtN);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "frmExercicio2";
            this.Text = "frmExercicio2";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtN;
        private System.Windows.Forms.Label lblNumero;
        private System.Windows.Forms.Button btnGerarNumeroH;
    }
}