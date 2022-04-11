namespace PTriangulos
{
    partial class form
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
            this.btnVerificar = new System.Windows.Forms.Button();
            this.lblLadoA = new System.Windows.Forms.Label();
            this.lblLadoB = new System.Windows.Forms.Label();
            this.lblLadoC = new System.Windows.Forms.Label();
            this.mskbxLadoA = new System.Windows.Forms.MaskedTextBox();
            this.mskbxLadoB = new System.Windows.Forms.MaskedTextBox();
            this.mskbxLadoC = new System.Windows.Forms.MaskedTextBox();
            this.SuspendLayout();
            // 
            // btnVerificar
            // 
            this.btnVerificar.Font = new System.Drawing.Font("MV Boli", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVerificar.Location = new System.Drawing.Point(12, 295);
            this.btnVerificar.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnVerificar.Name = "btnVerificar";
            this.btnVerificar.Size = new System.Drawing.Size(422, 82);
            this.btnVerificar.TabIndex = 0;
            this.btnVerificar.Text = "Verificar";
            this.btnVerificar.UseVisualStyleBackColor = true;
            this.btnVerificar.Click += new System.EventHandler(this.btnVerificar_Click);
            // 
            // lblLadoA
            // 
            this.lblLadoA.AutoSize = true;
            this.lblLadoA.Location = new System.Drawing.Point(14, 27);
            this.lblLadoA.Name = "lblLadoA";
            this.lblLadoA.Size = new System.Drawing.Size(70, 21);
            this.lblLadoA.TabIndex = 4;
            this.lblLadoA.Text = "Lado A:";
            // 
            // lblLadoB
            // 
            this.lblLadoB.AutoSize = true;
            this.lblLadoB.Location = new System.Drawing.Point(14, 111);
            this.lblLadoB.Name = "lblLadoB";
            this.lblLadoB.Size = new System.Drawing.Size(69, 21);
            this.lblLadoB.TabIndex = 5;
            this.lblLadoB.Text = "Lado B:";
            // 
            // lblLadoC
            // 
            this.lblLadoC.AutoSize = true;
            this.lblLadoC.Location = new System.Drawing.Point(15, 197);
            this.lblLadoC.Name = "lblLadoC";
            this.lblLadoC.Size = new System.Drawing.Size(69, 21);
            this.lblLadoC.TabIndex = 6;
            this.lblLadoC.Text = "Lado C:";
            // 
            // mskbxLadoA
            // 
            this.mskbxLadoA.Location = new System.Drawing.Point(19, 51);
            this.mskbxLadoA.Mask = "999.00";
            this.mskbxLadoA.Name = "mskbxLadoA";
            this.mskbxLadoA.Size = new System.Drawing.Size(415, 33);
            this.mskbxLadoA.TabIndex = 7;
            // 
            // mskbxLadoB
            // 
            this.mskbxLadoB.Location = new System.Drawing.Point(19, 135);
            this.mskbxLadoB.Mask = "999.00";
            this.mskbxLadoB.Name = "mskbxLadoB";
            this.mskbxLadoB.Size = new System.Drawing.Size(415, 33);
            this.mskbxLadoB.TabIndex = 8;
            // 
            // mskbxLadoC
            // 
            this.mskbxLadoC.Location = new System.Drawing.Point(19, 221);
            this.mskbxLadoC.Mask = "999.00";
            this.mskbxLadoC.Name = "mskbxLadoC";
            this.mskbxLadoC.Size = new System.Drawing.Size(415, 33);
            this.mskbxLadoC.TabIndex = 9;
            // 
            // form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(457, 399);
            this.Controls.Add(this.mskbxLadoC);
            this.Controls.Add(this.mskbxLadoB);
            this.Controls.Add(this.mskbxLadoA);
            this.Controls.Add(this.lblLadoC);
            this.Controls.Add(this.lblLadoB);
            this.Controls.Add(this.lblLadoA);
            this.Controls.Add(this.btnVerificar);
            this.Font = new System.Drawing.Font("MV Boli", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "form";
            this.Text = "Triângulos";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnVerificar;
        private System.Windows.Forms.Label lblLadoA;
        private System.Windows.Forms.Label lblLadoB;
        private System.Windows.Forms.Label lblLadoC;
        private System.Windows.Forms.MaskedTextBox mskbxLadoA;
        private System.Windows.Forms.MaskedTextBox mskbxLadoB;
        private System.Windows.Forms.MaskedTextBox mskbxLadoC;
    }
}

