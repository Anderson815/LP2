using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PTesteMetodo
{
    public partial class frmExercicio4 : Form
    {
        public frmExercicio4()
        {
            InitializeComponent();
        }

        private void btnQuantosNumeros_Click(object sender, EventArgs e)
        {
            //Char.isNumber(<o caracter>) e for

            //MessageBox.Show(rtbTexto.TextLength.ToString());

            int totalNumeros = 0;
            char[] caracteres = rtbTexto.Text.ToCharArray();
            
            for (int indice = 0; indice < rtbTexto.TextLength; indice++) {
                if(Char.IsNumber(caracteres[indice]))
                    totalNumeros++;
            }

            MessageBox.Show("O texto possui " + totalNumeros + " caracteres numéricos");
        }

        private void btnPrimeiroEspaco_Click(object sender, EventArgs e)
        {
            //Char.IsWhiteSpace(<o caracter>) e while
            char[] caracteres = rtbTexto.Text.ToCharArray();
            int indice = 0;
            int posicao = -1;

            while(indice < rtbTexto.TextLength)
            {
                if (Char.IsWhiteSpace(caracteres[indice]))
                {
                    posicao = indice;
                    break;
                }
                    
                indice++;
            }

            if (posicao > 0)
                MessageBox.Show("A primeira posição do espaço em branco é " + (posicao + 1) + " (indice " + posicao + " do vetor de char)");
            else
                MessageBox.Show("Não existe espaço em branco no texto");
        }

        private void btnQuantasLetras_Click(object sender, EventArgs e)
        {
            //Char.IsLetter(<o caracter>) e foreach
            int totalLetras = 0;
            char[] caracteres = rtbTexto.Text.ToCharArray();

            foreach(char letra in caracteres)
            {
                if (Char.IsLetter(letra))
                    totalLetras++;
            }

            MessageBox.Show("O texto possui " + totalLetras + " caracteres alfabéticos");
        }
    }
}
