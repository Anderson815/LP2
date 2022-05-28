using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.VisualBasic;

namespace PAtividade9
{
    public partial class frmExercicio2 : Form
    {
        public frmExercicio2()
        {
            InitializeComponent();
        }

        private void btnEntradaDados_Click(object sender, EventArgs e)
        {
            lstNotacao.Items.Clear();
            
            int[] vQtdaProdutos = new int[10];
            double[] vValorProdutos = new double[10];

            double fatura = 0;

            string auxiliarQuantidade = "";
            string auxiliarPreco = "";

            lstNotacao.Items.Add("COD\tQTDA.\tPreço");
            lstNotacao.Items.Add("----------------------------------------");

            for (var i = 0; i < vQtdaProdutos.Length; i++)
            {
                auxiliarQuantidade = Interaction.InputBox("Informe a quantidade de unidades do " + (i + 1) + "º  produto: ", "Informe quantidade");

                if (!int.TryParse(auxiliarQuantidade, out vQtdaProdutos[i]))
                {
                    MessageBox.Show("Quantidade Inválido!");
                    i--;
                }
                else
                {
                    if(vQtdaProdutos[i] < 0)
                    {
                        MessageBox.Show("Quantidade Inválido!");
                        i--;
                    }
                    else
                    {
                        do
                        {
                            auxiliarPreco = Interaction.InputBox("Informe o preço do " + (i + 1) + "º  produto: ", "Informe preço");

                            if (!double.TryParse(auxiliarPreco, out vValorProdutos[i]))
                                MessageBox.Show("Preço inválido");
                            else
                            {
                                if(vValorProdutos[i] < 0)
                                    MessageBox.Show("Preço inválido");
                                else
                                {
                                    lstNotacao.Items.Add((i + 1) + "\t" + vQtdaProdutos[i] + "\t" + vValorProdutos[i].ToString("N2"));
                                    fatura += (vValorProdutos[i] * vQtdaProdutos[i]);
                                }
                            }

                        } while(vValorProdutos[i] < 0);
                    }            
                }
            }

            lstNotacao.Items.Add("----------------------------------------");
            lstNotacao.Items.Add("Faturamento: R$ " + fatura.ToString("N2"));
        }
    }
}
