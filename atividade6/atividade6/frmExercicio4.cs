using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace atividade6
{
    public partial class frmExercicio4 : Form
    {
        public frmExercicio4()
        {
            InitializeComponent();
        }

      

        private void bttCalc_Click(object sender, EventArgs e)
        {
            string nome = txtNome.Text;
            string cargo = txtCarg.Text;
            string NumInsc = txtN_Insc.Text;
            double Sbruto;
            int b = 0, c = 0, d = 0;

            double producao, salario, gratificacao;
            if (double.TryParse(txtProd.Text, out producao) &&
                double.TryParse(txtSal.Text,  out salario) &&
                double.TryParse(txtGrat.Text, out gratificacao))
            {
                producao = double.Parse(txtProd.Text);
                salario = double.Parse(txtSal.Text);
                gratificacao = double.Parse(txtGrat.Text);

                if (producao >= 150) { d = 1; c = 1; b = 1;}
                else if (producao >= 120) { c = 1; b = 1; }
                else if (producao >= 100) { b = 1; }

                Sbruto = salario + salario * 
                    (0.05 * b + 0.1 * c + 0.1 * d) + gratificacao;

                txtResul.Text = Sbruto.ToString();

                if(Sbruto > 7000.0)
                {
                    if (producao >= 150 && gratificacao > 0)
                    {
                        MessageBox.Show("Este salario pode ser pago.");
                    }
                    else
                        MessageBox.Show("Este salario não pode ser pago.");
                }
            }
            else
                MessageBox.Show("Por favor informe dados corretos!\n\n" +
                    "Por favor, verifique os campos.\n" +
                    "Caso ocorra de campos vazios ou dados fora do contexto corrija");
        }
    }
}
