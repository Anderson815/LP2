﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PAtividade9
{
    public partial class frmExercicio3 : Form
    {
        public frmExercicio3()
        {
            InitializeComponent();
        }

        private void btnResposta_Click(object sender, EventArgs e)
        {
            
            string[] Alunos = {"Viviane", "André", "Hélio", "Denise", "Junior",
                "Leonardo", "Jose", "Nelma", "Tobby"};
            Int32 I, Total = 0;
            Int32 N = Alunos.Length;
            for (I = 0; I < N - 1; I++)
            {
                Total += Alunos[I].Length;
                MessageBox.Show("" + Total);
            }

            string alternativa = "";

            switch (Total)
            {
                case 51:
                    alternativa = "A";
                    break;

                case 50:
                    alternativa = "B";
                    break;

                case 46:
                    alternativa = "C";
                    break;

                case 48:
                    alternativa = "D";
                    break;
            }

            MessageBox.Show("A alternativa correta é a " + alternativa + " -> " + Total);
        }
    }
}
