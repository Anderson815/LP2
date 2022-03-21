using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PTesteEventos
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void txtNome_Leave(object sender, EventArgs e)
        {
            
        }

        private void txtNome_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (Char)13)
            {
                SendKeys.Send("{TAB}");
                e.Handled = true;
            }
        }

        private void txtNome_Validated(object sender, EventArgs e)
        {
            if(txtNome.Text == "")
            {
                MessageBox.Show("Nome vazio");
                txtNome.Focus();
            }
        }

        private void mskDataVencimento_Validating(object sender, CancelEventArgs e)
        {
            DateTime data;

            if(!DateTime.TryParse(mskDataVencimento.Text, out data))
            {
                MessageBox.Show("Data inválida");
                e.Cancel = true;
            }
        }

        private void btnEnviar_Click(object sender, EventArgs e)
        {
            if (txtNome.Text == "")
            {
                MessageBox.Show("Nome vazio");
                txtNome.Focus();
            }
            else
            {
                DateTime data;
                if (!DateTime.TryParse(mskDataVencimento.Text, out data))
                {
                    MessageBox.Show("Data inválida");
                    mskDataVencimento.Focus();
                }
                else
                {
                    Double valor;



                    if (!Double.TryParse(mskValor.Text, out valor))
                    {
                        MessageBox.Show("Valor inválido");
                        mskValor.Focus();
                    }
                }



            }


        }

        private void mskValor_Validated(object sender, EventArgs e)
        {
            
            Double valor;
            
            if (!Double.TryParse(mskValor.Text, out valor))
            {
                MessageBox.Show("Valor inválido");
                mskValor.Focus();
            }


        }
    }
}
