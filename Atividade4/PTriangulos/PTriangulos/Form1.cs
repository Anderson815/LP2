using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PTriangulos
{
    public partial class form : Form
    {

        double ladoA, ladoB, ladoC;

        public form()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnVerificar_Click(object sender, EventArgs e)
        {
            if (this.validacaoLado(mskbxLadoA.Text, "A") && this.validacaoLado(mskbxLadoB.Text, "B") && this.validacaoLado(mskbxLadoC.Text, "C"))
            {
                ladoA = Double.Parse(mskbxLadoA.Text);
                ladoB = Double.Parse(mskbxLadoB.Text);
                ladoC = Double.Parse(mskbxLadoC.Text);

                if(ladoA < (ladoB + ladoC) &&
                   ladoA > Math.Abs(ladoB - ladoC) &&
                   ladoB < (ladoA + ladoC) &&
                   ladoB > Math.Abs(ladoA - ladoC) &&
                   ladoC < (ladoA + ladoB) &&
                   ladoC > Math.Abs(ladoA - ladoB))
                {
                    
                    if(ladoA == ladoB && ladoB == ladoC)
                        MessageBox.Show("Equilátero");
                    else if(ladoA == ladoB || ladoA == ladoC || ladoB == ladoC)
                        MessageBox.Show("Isóceles");
                    else
                        MessageBox.Show("Escaleno");
                        
                } 

            }
                          
        }
    
        private bool validacaoLado(string entradaLado, string lado) 
        {
            double valorEntrada;
            bool valido = true;

            if (Double.TryParse(entradaLado, out valorEntrada))
                if (valorEntrada == 0)
                {
                    MessageBox.Show("lado " + lado + " com o valor 0");
                    valido = false;
                }
                    

            return valido;
        }
    }
}
