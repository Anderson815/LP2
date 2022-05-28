namespace PAtividade9
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
            this.btnEntradaNotas = new System.Windows.Forms.Button();
            this.lstNotas = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // btnEntradaNotas
            // 
            this.btnEntradaNotas.Location = new System.Drawing.Point(22, 12);
            this.btnEntradaNotas.Name = "btnEntradaNotas";
            this.btnEntradaNotas.Size = new System.Drawing.Size(415, 88);
            this.btnEntradaNotas.TabIndex = 2;
            this.btnEntradaNotas.Text = "Entrada de Notas";
            this.btnEntradaNotas.UseVisualStyleBackColor = true;
            this.btnEntradaNotas.Click += new System.EventHandler(this.btnEntradaNotas_Click);
            // 
            // lstNotas
            // 
            this.lstNotas.FormattingEnabled = true;
            this.lstNotas.Location = new System.Drawing.Point(22, 117);
            this.lstNotas.Name = "lstNotas";
            this.lstNotas.Size = new System.Drawing.Size(415, 290);
            this.lstNotas.TabIndex = 3;
            // 
            // frmExercicio5
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(476, 441);
            this.Controls.Add(this.lstNotas);
            this.Controls.Add(this.btnEntradaNotas);
            this.Name = "frmExercicio5";
            this.Text = "frmExercicio5";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnEntradaNotas;
        private System.Windows.Forms.ListBox lstNotas;
    }
}