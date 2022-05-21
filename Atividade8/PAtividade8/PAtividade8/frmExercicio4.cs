using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PAtividade8
{
    public partial class frmExercicio4 : Form
    {
        public frmExercicio4()
        {
            InitializeComponent();
        }

        private void btnCalcularSalarioBruto_Click(object sender, EventArgs e)
        {
            double salarioBruto = 0;

            double salario = validaValoresDouble(txtSalario.Text);
            double gratificacao = validaValoresDouble(txtGratificacao.Text);
            int producao = validaValoresInt(txtProducao.Text);

            bool valido = (salario != -1 && gratificacao != -1 && producao != -1);

            if (valido)
            {
                double a, b, c, d;

                a = salario;
                b = 0;
                c = 0;
                d = 0;

                if (producao >= 100)
                    b = 1;
                
                if (producao >= 120)
                    c = 1;

                if (producao >= 150)
                    d = 1;

                salarioBruto = a + a * (0.05 * b + 0.1 * c + 0.1 * d) + gratificacao;

                if(salarioBruto <= 7000.00)
                    MessageBox.Show("Salário Bruto a ser pago: R$ " + salarioBruto.ToString("N2"));
                else if(salarioBruto > 7000.00 && producao >= 150 && gratificacao > 0)
                    MessageBox.Show("Salário Bruto a ser pago: R$ " + salarioBruto.ToString("N2"));
                else
                    MessageBox.Show("Salário Bruto NÃO pode ser pago");

            }
            else
            {
                MessageBox.Show("Erro em algum campo numérico (produção, salário ou gratificação)");
            }


        }

        private double validaValoresDouble(string numeroTexto)
        {
            double n;

            if (numeroTexto == "")
                n = -1;
            else
            {
                if (!double.TryParse(numeroTexto, out n))
                    n = -1;
                else
                    if (n < 0)
                    n = -1;
            }

            return n;
        }

        private int validaValoresInt(string numeroTexto)
        {
            int n;

            if (numeroTexto == "")
                n = -1;
            else
            {
                if (!int.TryParse(numeroTexto, out n))
                    n = -1;
                else
                    if (n < 0)
                    n = -1;
            }

            return n;
        }

    }
}
