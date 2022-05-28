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
    public partial class frmExercicio1 : Form
    {
        public frmExercicio1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int[] vNum = new int[20];

            string auxiliar = "";

            for (var i = 0; i < vNum.Length; i++ )
            {
                auxiliar = Interaction.InputBox("Informe o " + (i + 1) + "º  número : ", "Entrada de dados");

                if (auxiliar == "")
                    break;
                else
                {
                    if (!int.TryParse(auxiliar, out vNum[i]))
                    {
                        MessageBox.Show("Número Inválido!");
                        i--;
                    }
                }
            }

            Array.Reverse(vNum);
            auxiliar = "";

            foreach(int inteiro in vNum){
                auxiliar += "\n" + inteiro;
            }

            MessageBox.Show(auxiliar);
            
        }
    }
}
