namespace PImc
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
            this.lblAltura = new System.Windows.Forms.Label();
            this.lblPeso = new System.Windows.Forms.Label();
            this.mskbxAltura = new System.Windows.Forms.MaskedTextBox();
            this.mskbxPeso = new System.Windows.Forms.MaskedTextBox();
            this.btnLimpar = new System.Windows.Forms.Button();
            this.btnCalcular = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblAltura
            // 
            this.lblAltura.AutoSize = true;
            this.lblAltura.Location = new System.Drawing.Point(23, 24);
            this.lblAltura.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblAltura.Name = "lblAltura";
            this.lblAltura.Size = new System.Drawing.Size(51, 20);
            this.lblAltura.TabIndex = 0;
            this.lblAltura.Text = "Altura";
            // 
            // lblPeso
            // 
            this.lblPeso.AutoSize = true;
            this.lblPeso.Location = new System.Drawing.Point(23, 81);
            this.lblPeso.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblPeso.Name = "lblPeso";
            this.lblPeso.Size = new System.Drawing.Size(45, 20);
            this.lblPeso.TabIndex = 1;
            this.lblPeso.Text = "Peso";
            // 
            // mskbxAltura
            // 
            this.mskbxAltura.Location = new System.Drawing.Point(117, 24);
            this.mskbxAltura.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.mskbxAltura.Mask = "0.00";
            this.mskbxAltura.Name = "mskbxAltura";
            this.mskbxAltura.Size = new System.Drawing.Size(206, 26);
            this.mskbxAltura.TabIndex = 2;
            // 
            // mskbxPeso
            // 
            this.mskbxPeso.Location = new System.Drawing.Point(117, 76);
            this.mskbxPeso.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.mskbxPeso.Mask = "900.00";
            this.mskbxPeso.Name = "mskbxPeso";
            this.mskbxPeso.Size = new System.Drawing.Size(206, 26);
            this.mskbxPeso.TabIndex = 3;
            // 
            // btnLimpar
            // 
            this.btnLimpar.Location = new System.Drawing.Point(27, 190);
            this.btnLimpar.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnLimpar.Name = "btnLimpar";
            this.btnLimpar.Size = new System.Drawing.Size(298, 35);
            this.btnLimpar.TabIndex = 4;
            this.btnLimpar.Text = "Limpar";
            this.btnLimpar.UseVisualStyleBackColor = true;
            this.btnLimpar.Click += new System.EventHandler(this.btnLimpar_Click);
            // 
            // btnCalcular
            // 
            this.btnCalcular.Location = new System.Drawing.Point(27, 145);
            this.btnCalcular.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnCalcular.Name = "btnCalcular";
            this.btnCalcular.Size = new System.Drawing.Size(298, 35);
            this.btnCalcular.TabIndex = 5;
            this.btnCalcular.Text = "Calcular";
            this.btnCalcular.UseVisualStyleBackColor = true;
            this.btnCalcular.Click += new System.EventHandler(this.btnCalcular_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(357, 262);
            this.Controls.Add(this.btnCalcular);
            this.Controls.Add(this.btnLimpar);
            this.Controls.Add(this.mskbxPeso);
            this.Controls.Add(this.mskbxAltura);
            this.Controls.Add(this.lblPeso);
            this.Controls.Add(this.lblAltura);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Form1";
            this.Text = "IMC";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblAltura;
        private System.Windows.Forms.Label lblPeso;
        private System.Windows.Forms.MaskedTextBox mskbxAltura;
        private System.Windows.Forms.MaskedTextBox mskbxPeso;
        private System.Windows.Forms.Button btnLimpar;
        private System.Windows.Forms.Button btnCalcular;
    }
}

