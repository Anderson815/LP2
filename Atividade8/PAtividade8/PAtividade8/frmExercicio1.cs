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
    public partial class frmExercicio1 : Form
    {

        public frmExercicio1()
        {
            InitializeComponent();
        }

        private void btnEspacoBranco_Click(object sender, EventArgs e)
        {
            MessageBox.Show("A quantidade de espaços em branco é " + quantificador(' '));
        }


        private void btnNumerosR_Click(object sender, EventArgs e)
        {
            MessageBox.Show("A quantidade de Rs é " + quantificador('R'));
        }

        private void btnParesLetras_Click(object sender, EventArgs e)
        {
            MessageBox.Show("A quantidade de pares seguidos é " + letrasRepetidas());
        }

        private int quantificador(char caracterComparado)
        { 
            int quantidade = 0;
            char[] letras = rtbTexto.Text.ToCharArray();

            caracterComparado = Char.ToUpper(caracterComparado);

            for (int contador = 0; contador < letras.Length; contador++)
            {
                if (Char.ToUpper(letras[contador]) == caracterComparado)
                    quantidade++;
            }             

            return quantidade;
        }

        private int letrasRepetidas() {
            int quantidade = 0;
            char[] letras = rtbTexto.Text.ToCharArray();

            for (int contador = 0; contador < letras.Length; contador++)
            {
                if (contador > 0)
                    if (Char.ToUpper(letras[contador]) == Char.ToUpper(letras[contador - 1]))
                        quantidade++;
            }

            return quantidade;
        }
    }
}
