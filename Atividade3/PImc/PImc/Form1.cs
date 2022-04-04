using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PImc
{
    public partial class Form1 : Form
    {

        double altura, peso, imc;

        public Form1()
        {
            InitializeComponent();
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            mskbxAltura.Clear();
            mskbxPeso.Clear();
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            
            if(double.TryParse(mskbxAltura.Text, out altura))
            {
                if (altura == 0)
                {
                    MessageBox.Show("A altura não pode ser igual a 0");
                    mskbxAltura.Focus();
                }

                else 
                {
                    if (double.TryParse(mskbxPeso.Text, out peso)) 
                    {
                        if (peso == 0)
                        {
                            MessageBox.Show("O peso não pode ser igual a 0");
                            mskbxPeso.Focus();
                        }
                        else
                        {
                            peso = Math.Round(peso, 1);
                            altura = Math.Round(altura, 1);

                            imc = peso / Math.Pow(altura, 2);
                            //MessageBox.Show("O IMC é " + imc);
                            this.exibirMensagem();
                        }
                    }                
                }   
            }
            

            /*
            this.validaAltura();
            if (altura > 0) 
            { 
                this.validaPeso();
                if (peso > 0)
                {
                    imc = peso / Math.Pow(altura, 2);
                    MessageBox.Show("O IMC é " + imc);
                }
            }
             */
        }
/*
        private void validaAltura(){
            altura = 0;

            if (double.TryParse(mskbxAltura.Text, out altura))
            {
                if (altura == 0)
                {
                    MessageBox.Show("A altura não pode ser igual a 0");
                    mskbxAltura.Focus();
                }
                else
                    altura = Math.Round(altura, 1);
            }
        }

        private void validaPeso() {
            peso = 0;

            if (double.TryParse(mskbxPeso.Text, out peso))
            {
                if (peso == 0)
                {
                    MessageBox.Show("O peso não pode ser igual a 0");
                    mskbxPeso.Focus();
                }
                else
                    peso = Math.Round(peso, 1);
            }
        }

 */
        private void exibirMensagem() {
            if (imc < 18.5)
                MessageBox.Show("classificação: Magreza\nObesidade(Grau): 0");
            else if (imc <= 24.9)
                MessageBox.Show("classificação: Normal\nObesidade(Grau): 0");
            else if (imc <= 29.9)
                MessageBox.Show("classificação: Sobrepeso\nObesidade(Grau): 1");
            else if (imc <= 39.9)
                MessageBox.Show("classificação: Obesidade\nObesidade(Grau): 2");
            else
                MessageBox.Show("classificação: Obesidade Grave\nObesidade(Grau): 3");
        }

    }
}
