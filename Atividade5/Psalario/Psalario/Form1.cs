using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Psalario
{
    public partial class Form1 : Form
    {

        string nome;
        double salarioBruto;
        byte quantidadeFilhos;

        public Form1()
        {
            InitializeComponent();
            lblDados.Text = "";
        }



        private bool validaGeral()
        {

            bool isErro = false;
            string erro = "";

            nome = txtNomeFuncionario.Text;
            quantidadeFilhos = Byte.Parse(nudNumeroFilhos.Text);

            if (nome == "")
            {
                erro = "EERO: Nome inválido";
                isErro = true;
            }

            try
            {
                salarioBruto = Convert.ToDouble(mskbxSalario.Text);

                if (salarioBruto <= 0)
                {
                    erro = "ERRO: Salário igual a 0";
                    isErro = true;
                }
            }catch (FormatException e)
            {
                erro = "ERRO: Salário não informado";
            }
            if(erro != "")
                MessageBox.Show(erro);

            return isErro;
        }

        private void btnVerificaDesconto_Click(object sender, EventArgs e)
        {
            validaGeral();
            mensagemLblDados();
            calculos();
        }

        private void mensagemLblDados() {
            string abreviacaoPronomeTratamento = "";
            string casadoOuSolteiro = "";

            abreviacaoPronomeTratamento = descobrePronomeTratamento();
            casadoOuSolteiro = descobreEstadoCivil(abreviacaoPronomeTratamento);

            lblDados.Text = "Os descontos do salário " + abreviacaoPronomeTratamento + " " + nome + "\nque é " + casadoOuSolteiro + " e que tem " + quantidadeFilhos + " filhos(s) são:";
        }

        //INÍCIO - Auxiliares do mensagemLblDados
        private string descobrePronomeTratamento(){
            string tratamento = "";

            if (rbtnFeminino.Checked)
                tratamento = "da Sra.";
            else
                tratamento = "do Sr.";

            return tratamento;
        }

        private string descobreEstadoCivil(string tratamento) {
            string estadoCivil = "";

            if (tratamento == "da Sra." && chkbxCasado.Checked)
                estadoCivil = "Casada";
            else if (tratamento == "da Sra." && !chkbxCasado.Checked)
                estadoCivil = "Solteira";
            else if (tratamento == "do Sr." && chkbxCasado.Checked)
                estadoCivil = "Casado";
            else if (tratamento == "do Sr." && !chkbxCasado.Checked)
                estadoCivil = "Solteiro";

            return estadoCivil;
        }
        //FIM - Auxiliares do mensagemLblDados

        private void calculos() 
        {
            double aliquotaINSS = 0, aliquotaIRPF = 0, descontoINSS = 0, descontoIRPF = 0, salarioFamilia = 0, salarioLiquido = 0;

            aliquotaINSS = calculaAliquotaINSS();
            aliquotaIRPF = calculaAliquotaIRPF();

            descontoINSS = calculaDescontoINSS(aliquotaINSS);
            descontoIRPF = calculaDescontoIRPF(aliquotaIRPF);

            salarioFamilia = calculaSalarioFamilia();
            salarioLiquido = calculaSalarioLiquido(descontoINSS, descontoIRPF, salarioFamilia);

            aliquotaINSS *= 100;
            aliquotaIRPF *= 100;
            //Exibi valores

            txtAliquotaINSS.Text = aliquotaINSS.ToString() + " %";
            txtAliquotaIRPF.Text = aliquotaIRPF.ToString() + " %";

            txtDescontoINSS.Text = descontoINSS.ToString("N2");
            txtDescontoIRPF.Text = descontoIRPF.ToString("N2");

            txtSalarioFamilia.Text = salarioFamilia.ToString("N2");
            txtSalarioLiquido.Text = salarioLiquido.ToString("N2");

        }

        //INÍCIO - auxiliares calculos
        private double calculaAliquotaINSS() 
        {
            // 2) Os cálculos são os seguintes:(OS VALORES SÃO FICTÍCIOS)
            // Aliquota INSS para Salário Bruto:
            // Até 800.47 - 7.65%
            // De 800.48 a 1050 - 8.65%
            // De 1050.01 a 1400.77 – 9.00%
            // De 1400.78 a 2801.56 – 11.00%
            // >2801.56 -> Desconto = 308.17 (teto)

            double aliquotaINSS = 0;

                if(salarioBruto <= 800.47)
                    aliquotaINSS = 0.0765;
                else if(salarioBruto <= 1050)
                    aliquotaINSS = 0.0865;
                else if(salarioBruto <= 1400.77)
                    aliquotaINSS = 0.09;
                else if(salarioBruto <= 2801.56)
                    aliquotaINSS = 0.11;

            return aliquotaINSS;
        }

        private double calculaAliquotaIRPF()
        {
            double aliquotaIRPF = 0;

            // Alíquota IRPF para Salário Bruto:
            // Até 1257.12 - isento
            // De 1257.13 a 2512.08 – 15.00%
            // > 2512.08 - 27.5%

            if(salarioBruto > 2512.08)
                aliquotaIRPF = 0.275;
            else if(salarioBruto >= 1257.13)
                aliquotaIRPF = 0.15;

            return aliquotaIRPF;
        }

        private double calculaDescontoINSS(double aliquotaINSS)
        {
            double descontoINSS = 0;

            if(aliquotaINSS != 0)
                descontoINSS = salarioBruto * aliquotaINSS;
            else
                descontoINSS = 308.17;

            return descontoINSS;
        }

        private double calculaDescontoIRPF(double aliquotaIRPF)
        {
            double descontoIRPF = 0;

            descontoIRPF = salarioBruto * aliquotaIRPF;

            return descontoIRPF;
        }

        private double calculaSalarioFamilia()
        {
            double salarioFamilia = 0;

            // Salário Família para Salário Bruto:
            // Até 435.52 - 22.33 por filho
            // De 435.53 a 654.61 - 15.74 por filho
            // >654.61 – 0

            if(salarioBruto <= 435.52)
                salarioFamilia = quantidadeFilhos * 22.33;
            else if(salarioBruto <= 654.61)
                salarioFamilia = quantidadeFilhos * 15.74;

            return salarioFamilia;
        }

        private double calculaSalarioLiquido(double descontoINSS, double descontoIRPF, double salarioFamilia)
        {
            return salarioBruto - descontoINSS - descontoIRPF + salarioFamilia;
        }

        //FIM - auxiliares calculos
    }
}
