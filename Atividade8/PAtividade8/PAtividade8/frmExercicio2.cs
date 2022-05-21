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
    public partial class frmExercicio2 : Form
    {
        public frmExercicio2()
        {
            InitializeComponent();
        }

        private void btnGerarNumeroH_Click(object sender, EventArgs e)
        {
            int n = validarEntrada(txtN.Text);
            if (n != -1)
            {
                double h = calculo(n);
                MessageBox.Show("O valor de H é " + h);
            }
            else
                MessageBox.Show("Número inválido");
                
            //MessageBox.Show("" + n);
        }

        private int validarEntrada(string numeroTexto) {
            int n;

            if (numeroTexto == "")
                n = -1;
            else
            {
                if (!int.TryParse(numeroTexto, out n))
                    n = -1;
                else
                    if (n < 1)
                        n = -1;
            }
                
            return n;
        }

        private double calculo(int n) {
            double h = 0;

            for (int contador = 1; contador <= n; contador++)
            {
                double aux = 1 / (double) contador;
                h += aux;
            }

            return h;
        }

    }
}
