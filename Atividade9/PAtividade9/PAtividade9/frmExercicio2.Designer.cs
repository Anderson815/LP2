namespace PAtividade9
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
            this.btnEntradaDados = new System.Windows.Forms.Button();
            this.lstNotacao = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // btnEntradaDados
            // 
            this.btnEntradaDados.Location = new System.Drawing.Point(28, 23);
            this.btnEntradaDados.Name = "btnEntradaDados";
            this.btnEntradaDados.Size = new System.Drawing.Size(411, 88);
            this.btnEntradaDados.TabIndex = 1;
            this.btnEntradaDados.Text = "Entrada de Dados";
            this.btnEntradaDados.UseVisualStyleBackColor = true;
            this.btnEntradaDados.Click += new System.EventHandler(this.btnEntradaDados_Click);
            // 
            // lstNotacao
            // 
            this.lstNotacao.FormattingEnabled = true;
            this.lstNotacao.Location = new System.Drawing.Point(28, 129);
            this.lstNotacao.Name = "lstNotacao";
            this.lstNotacao.Size = new System.Drawing.Size(411, 225);
            this.lstNotacao.TabIndex = 4;
            // 
            // frmExercicio2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(470, 392);
            this.Controls.Add(this.lstNotacao);
            this.Controls.Add(this.btnEntradaDados);
            this.Name = "frmExercicio2";
            this.Text = "frmExercicio2";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnEntradaDados;
        private System.Windows.Forms.ListBox lstNotacao;
    }
}