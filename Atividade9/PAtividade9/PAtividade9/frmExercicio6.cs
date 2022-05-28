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
    public partial class frmExercicio6 : Form
    {
        public frmExercicio6()
        {
            InitializeComponent();
        }

        private void btnExecutar_Click(object sender, EventArgs e)
        {
            lstPessoa.Items.Clear();

            string[] nomes = new string[6];
            int[] tamanhoNomes = new int[6];

            for (int i = 0; i < nomes.Length; i++)
            {
                nomes[i] = carregarNomes(i);
                tamanhoNomes[i] = tamanhoNome(nomes[i]);

                lstPessoa.Items.Add("O nome: " + nomes[i] + " tem " + tamanhoNomes[i] + " caracteres");
            }


        }

        private string carregarNomes(int i) {
            string auxiliar = "", nome = "";
            bool repetir = false;

            do
            {
                auxiliar = Interaction.InputBox("Informe o nome da " + (i + 1) + "º  pessoa: ", "Informe o nome");
                
                if(auxiliar == "")
                {
                    MessageBox.Show("Nome inválido");
                    repetir = true;
                }
                else
                {
                    nome = auxiliar;
                    repetir = false;
                }
            }while(repetir);
            

            return nome;
        }

        private int tamanhoNome(string nome) {
            int tamanhoNome = 0;

            nome = nome.Trim().Replace(" ", "");
            tamanhoNome = nome.Length;

            return tamanhoNome;
        }
    }
}
