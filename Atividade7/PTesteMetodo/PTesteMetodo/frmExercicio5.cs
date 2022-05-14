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
    public partial class frmExercicio5 : Form
    {
        public frmExercicio5()
        {
            InitializeComponent();
        }

        private void btnSortear_Click(object sender, EventArgs e)
        {
            int numero1 = validaNumero(txtNumero1.Text);
            int numero2 = validaNumero(txtNumero2.Text);
            int numeroSorteado;
            Random random = new Random();

            if(numero1 > -1 && numero2 > -1)
            {
                if (numero2 > numero1)
                {
                    numeroSorteado = random.Next(numero1, numero2 + 1);
                    MessageBox.Show("O número sorteado é " + numeroSorteado);
                }
                else
                    MessageBox.Show("Erro: Número 2 menor ou igual ao número 1!");
            }


            
        }

        private int validaNumero(string numeroTexto) {
            int resultado;

            if(!int.TryParse(numeroTexto, out resultado))
            {
                MessageBox.Show("Erro: Você não digitou um número válido!");
                resultado = -1;
            }

            return resultado;
        }
    }
}
