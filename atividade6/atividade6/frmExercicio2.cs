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
    public partial class frmExercicio2 : Form
    {
        public frmExercicio2()
        {
            InitializeComponent();
        }

        private void bttcalc_Click(object sender, EventArgs e)
        {
            int N;
            if (int.TryParse(txtNumN.Text, out N))
            {
                N = int.Parse(txtNumN.Text);
                if (N != 0)
                {

                    double H = 0,y;
                    for (var x = 1; x <= N; x++)
                    /* codigo para calculo exato nota ele vai somente ate vinte numeros
                Decimal H = 0;
                int Q=0;
                int den =1;
                for (var x = 1; x <= N; x++)
                {
                        den = den * x;

                }
                for(var x = 1;x<=N;x++)
                {
                    Q=(den/x)+Q;
                }
                H=Q/(decimal)den;*/
                    {
                        y = 1;
                        y = y / x;
                        H = H + y;
                    }
                    txtResult.Text = H.ToString("N2");
                }
                else
                    MessageBox.Show("Você informou 0!");
            }
            else
                MessageBox.Show("Informe dados corretamente");


        }
    }
}
