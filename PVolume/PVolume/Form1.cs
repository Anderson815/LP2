using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PVolume
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            //Validação
            Double raio, altura, volume;

            do
            {
                raio = this.ValidacaoRaio();
                if (raio == -1) txtRaio.Focus();
            } while (true);
            altura = this.ValidacaoAltura();
            
            

            volume = Math.PI * Math.Pow(raio, 2) * altura;

            txtVolume.Text = volume.ToString("N2");
        }

        private void txtRaio_Validated(object sender, EventArgs e)
        {
            this.ValidacaoRaio();
        }

        private void txtAltura_Validated(object sender, EventArgs e)
        {
            this.ValidacaoAltura();
        }

        //Auxiliares

        private Double ValidacaoRaio() 
        {
            Double raio;

            if (!Double.TryParse(txtRaio.Text, out raio))
            {
                MessageBox.Show("Raio inválido!");
                raio = -1;
            }
            else
            {
                if (raio <= 0)
                {
                    MessageBox.Show("Raio deve ser maior que zero!");
                    raio = -1;
                }
            }

            return raio;
        }

        private Double ValidacaoAltura() {
            Double altura;

            if (!Double.TryParse(txtAltura.Text, out altura))
            {
                MessageBox.Show("Altura inválido!");
            }
            else
            {
                if (altura <= 0)
                {
                    MessageBox.Show("Altura deve ser maior que zero!");
                }
            }

            return altura;
        }

        private void btnFechar_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
