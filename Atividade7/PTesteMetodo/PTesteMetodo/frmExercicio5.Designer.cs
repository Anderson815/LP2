namespace PTesteMetodo
{
    partial class frmExercicio5
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
            this.txtNumero2 = new System.Windows.Forms.TextBox();
            this.txtNumero1 = new System.Windows.Forms.TextBox();
            this.lblNumero2 = new System.Windows.Forms.Label();
            this.lblNumero1 = new System.Windows.Forms.Label();
            this.btnSortear = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtNumero2
            // 
            this.txtNumero2.Location = new System.Drawing.Point(106, 68);
            this.txtNumero2.Name = "txtNumero2";
            this.txtNumero2.Size = new System.Drawing.Size(187, 20);
            this.txtNumero2.TabIndex = 7;
            // 
            // txtNumero1
            // 
            this.txtNumero1.Location = new System.Drawing.Point(106, 34);
            this.txtNumero1.Name = "txtNumero1";
            this.txtNumero1.Size = new System.Drawing.Size(187, 20);
            this.txtNumero1.TabIndex = 6;
            // 
            // lblNumero2
            // 
            this.lblNumero2.AutoSize = true;
            this.lblNumero2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNumero2.Location = new System.Drawing.Point(19, 68);
            this.lblNumero2.Name = "lblNumero2";
            this.lblNumero2.Size = new System.Drawing.Size(68, 16);
            this.lblNumero2.TabIndex = 5;
            this.lblNumero2.Text = "Número 2:";
            // 
            // lblNumero1
            // 
            this.lblNumero1.AutoSize = true;
            this.lblNumero1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNumero1.Location = new System.Drawing.Point(19, 34);
            this.lblNumero1.Name = "lblNumero1";
            this.lblNumero1.Size = new System.Drawing.Size(68, 16);
            this.lblNumero1.TabIndex = 4;
            this.lblNumero1.Text = "Número 1:";
            // 
            // btnSortear
            // 
            this.btnSortear.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSortear.Location = new System.Drawing.Point(22, 112);
            this.btnSortear.Name = "btnSortear";
            this.btnSortear.Size = new System.Drawing.Size(271, 84);
            this.btnSortear.TabIndex = 8;
            this.btnSortear.Text = "Sortear";
            this.btnSortear.UseVisualStyleBackColor = true;
            this.btnSortear.Click += new System.EventHandler(this.btnSortear_Click);
            // 
            // frmExercicio5
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(320, 224);
            this.Controls.Add(this.btnSortear);
            this.Controls.Add(this.txtNumero2);
            this.Controls.Add(this.txtNumero1);
            this.Controls.Add(this.lblNumero2);
            this.Controls.Add(this.lblNumero1);
            this.Name = "frmExercicio5";
            this.Text = "Exercício 5";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtNumero2;
        private System.Windows.Forms.TextBox txtNumero1;
        private System.Windows.Forms.Label lblNumero2;
        private System.Windows.Forms.Label lblNumero1;
        private System.Windows.Forms.Button btnSortear;
    }
}