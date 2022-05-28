using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Collections;

namespace PAtividade9
{
    public partial class frmExercicio4 : Form
    {
        public frmExercicio4()
        {
            InitializeComponent();
        }

        private void btnArray_Click(object sender, EventArgs e)
        {
            ArrayList listaAlunos = new ArrayList();

            //Ana, André, Débora, Fátima, João, Janete, Otávio, Marcelo, Pedro, Thais.

            listaAlunos.Add("Ana");
            listaAlunos.Add("André");
            listaAlunos.Add("Débora");
            listaAlunos.Add("Fátima");
            listaAlunos.Add("João");
            listaAlunos.Add("Janete");
            listaAlunos.Add("Otávio");
            listaAlunos.Add("Marcelo");
            listaAlunos.Add("Pedro");
            listaAlunos.Add("Thais");

            listaAlunos.Remove("Otávio");

            foreach (string aluno in listaAlunos)
                lstAlunos.Items.Add(aluno);
        }

        private void lstAlunos_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
