using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PCalculadora
{
    public partial class Form1 : Form
    {
        double numero1, numero2, resultado;

        public Form1()
        {
            InitializeComponent();
        }

        private bool ValidacaoGeral() {
            bool retorno = true;

            if (!Double.TryParse(this.txtNumero1.Text, out numero1))
            {
                MessageBox.Show("Número 1 Inválido!");
                retorno = false;
            }

            else if (!Double.TryParse(this.txtNumero2.Text, out numero2))
            {
                MessageBox.Show("Número 2 Inválido!");
                retorno = false;
            }    

            return retorno;
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            this.txtNumero1.Text= "";
            this.txtNumero2.Text = "";
            this.txtResultado.Text = "";
        }

        private void btnSubtrair_Click(object sender, EventArgs e)
        {
            if (this.ValidacaoGeral())
            {
                resultado = numero1 - numero2;
                this.txtResultado.Text = resultado.ToString();
            }
        }

        private void btnMultiplicar_Click(object sender, EventArgs e)
        {
            if (this.ValidacaoGeral())
            {
                resultado = numero1 * numero2;
                this.txtResultado.Text = resultado.ToString();
            }
        }

        private void btnDividir_Click(object sender, EventArgs e)
        {
            if (this.ValidacaoGeral())
            {
                if (numero2 == 0) {
                    MessageBox.Show("Divisão por 0!");
                }
                else
                {
                    resultado = numero1 / numero2;
                    this.txtResultado.Text = resultado.ToString();
                }         
            }
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnSomar_Click(object sender, EventArgs e)
        {
            if (this.ValidacaoGeral())
            {
                resultado = numero1 + numero2;
                this.txtResultado.Text = resultado.ToString();
            }

        }

    }
}
