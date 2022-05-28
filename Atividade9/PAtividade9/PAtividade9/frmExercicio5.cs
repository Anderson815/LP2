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
    public partial class frmExercicio5 : Form
    {
        public frmExercicio5()
        {
            InitializeComponent();
        }

        private void btnEntradaNotas_Click(object sender, EventArgs e)
        {
            lstNotas.Items.Clear();

            double[ , ] matrizNotas = new double[20, 3];

            string auxiliar = "";

            double media = 0;


            for (var i = 0; i < 20; i++) //Alunos
            {

                media = 0;

                for (var j = 0; j < 3; j++ ) //Notas
                {


                    auxiliar = Interaction.InputBox("Digite a nota " + (j + 1) + "° do aluno " + (i + 1) + " :", "Entrada das notas");
                    if (double.TryParse(auxiliar, out matrizNotas[i, j]))
                    {
                        if (matrizNotas[i, j] < 0 || matrizNotas[i, j] > 10)
                        {
                            MessageBox.Show("Nota Inválida!");
                            j--;
                        }
                        else
                            media += matrizNotas[i, j];
                    }
                    else
                    {
                        MessageBox.Show("Nota Inválida!");
                        j--;
                    }               
                    
                }

                media /= 3;

                lstNotas.Items.Add("Aluno: " + (i + 1) + "\t Média: " + media.ToString("N2"));
            }
        }
    }
}
