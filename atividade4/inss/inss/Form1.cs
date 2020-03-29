using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace inss
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Casado_CheckedChanged(object sender, EventArgs e)
        {

        }

        string srfunc;
        private void Macho_CheckedChanged(object sender, EventArgs e)
        {
            srfunc = " do Sr.";
        }
        private void Femea_CheckedChanged(object sender, EventArgs e)
        {
            srfunc = "da Sra.";
        }
        private void Desconto_Click(object sender, EventArgs e)
        {
            double nfilhos, salariob, inss,irpff, saliq;
            string nomefunc;

            nomefunc = (Nome.Text);
            if (double.TryParse(Sbruto.Text, out salariob) && double.TryParse(Filhos.Text, out nfilhos))
            {
                nfilhos = int.Parse(Filhos.Text);
                salariob = Double.Parse(Sbruto.Text);

                richTextBox1.Visible = true;
                if (Casado.Checked == true)
                {
                    richTextBox1.Text = "Os descontos " + srfunc + nomefunc 
                        + " que é casado(a) e que tem " + nfilhos + " filhos são:";
                }

                else
                {
                    richTextBox1.Text = "Os descontos " + srfunc + nomefunc 
                        + " que é solteiro(a) e que tem " + nfilhos + " filhos são:";
                }
                
                if (salariob <= 800.47)
                {
                    AliInss.Text = "7.65%";

                    inss = salariob * 0.0765;

                    dInss.Text = inss.ToString("N2") + "$";
                }

                else if (salariob <=1050)
                {
                    AliInss.Text = "8.65%";
                    inss = salariob * 0.0865;
                    dInss.Text = inss.ToString("N2") + "$";
                }

                else if (salariob <= 1400.77)
                {
                    AliInss.Text = "9.00%";
                    inss = salariob * 0.09;
                    dIrpf.Text = inss.ToString("N2") + "$";
                }
                else if (salariob <= 2801.56)
                {
                    AliInss.Text = "11.00%";
                    inss = salariob * 0.11;
                    dIrpf.Text = inss.ToString("N2") + "$";
                }

                else
                {
                    AliInss.Text = "308.17$$";
                    inss = 308.17;
                    dIrpf.Text = inss.ToString("N2") + "$";
                }

                if (salariob <= 1257.12)
                {
                    irpf.Text = "0.00$$";
                    irpff = 0;
                    dIrpf.Text = irpff.ToString("N2") + "$";

                }
                else if (salariob <= 2512.08)
                {
                    irpf.Text = "15%";
                    irpff = salariob * 0.15;
                    dIrpf.Text = irpff.ToString("N2") + "$";
                }
                else 
                {
                    irpf.Text = "27.5%";
                    irpff = salariob * 0.275;
                    dIrpf.Text = irpff.ToString("N2") + "$";
                }

                if (salariob <= 432.52)
                {
                    nfilhos = (22.33 * nfilhos);
                    sfilhos.Text = nfilhos.ToString("N2") + "$";
                }
                else if (salariob <= 654.61)
                {
                    nfilhos = (15.74 * nfilhos);
                    sfilhos.Text = nfilhos.ToString("N2") + "$";
                }
                else
                {
                    nfilhos = (0);
                    sfilhos.Text = nfilhos.ToString("N2") + "$";
                }

                saliq = salariob - inss - irpff + nfilhos;

                salario.Text = saliq.ToString("N2") + "$";
            }
            else
                MessageBox.Show("por favor informe valores validos :D");
        }
    }
}
