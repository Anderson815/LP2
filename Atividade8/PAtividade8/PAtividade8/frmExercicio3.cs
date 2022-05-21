using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PAtividade8
{
    public partial class frmExercicio3 : Form
    {
        public frmExercicio3()
        {
            InitializeComponent();
        }

        private void btnVerificarPalindromo_Click(object sender, EventArgs e)
        {
            string textoOriginal = txtTexto.Text.Trim();
            textoOriginal = textoOriginal.Replace(" ", "").ToLower();

            char[] inverte = textoOriginal.ToCharArray();
            Array.Reverse(inverte);

            string textoInvertido = "";

            for (int contador = 0; contador < textoOriginal.Length; contador++)
            {
                textoInvertido = textoInvertido + Convert.ToString(inverte[contador]);
            }

            if(textoInvertido == textoOriginal)
                MessageBox.Show("É palíndromo");
            else
                MessageBox.Show("Não é palíndromo");        

        }
    }
}
