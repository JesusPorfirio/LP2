using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace indice_massa_corporal
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public int checador = 0;

        private void homem_CheckedChanged(object sender, EventArgs e)
        {
            checador = 1;
        }
        
        private void mulher_CheckedChanged(object sender, EventArgs e)
        {
            checador = 2;
        }
        private void IMC_Click(object sender, EventArgs e)
        {

            double pes, tam, imc;
            if (double.TryParse(gordura.Text, out pes)
                && double.TryParse(tamanho.Text, out tam))
            {
                pes = Convert.ToDouble(gordura.Text);
                
                tam = Convert.ToDouble(tamanho.Text);
                
                if (checador == 0)
                    _ = MessageBox.Show("Informe seu genero");

                else if (checador == 1)
                {
                    imc = (72.7 * tam); pes = 58 + pes; imc = imc - pes;
                    

                    if (imc == 0)
                        resultado.Text = ("peso ideal");

                    else if (imc < 0)
                        resultado.Text = ("peso acima do ideal");

                    else if (imc > 0) 
                    
                        resultado.Text = ("peso abaixo do ideal");    
                     
                }
                else if (checador == 2)
                {
                    imc = ((52.10 * tam) - 44.70) - pes;
                    if (imc < 0)
                        resultado.Text = ("peso acima do ideal");
                    else if (imc > 0)
                        resultado.Text = ("peso abaixo do ideal");
                    else if (imc == 0)
                        resultado.Text = ("peso ideal");
                }
            }
            else
               MessageBox.Show("informe valores em numeros");
        }

        private void maskedTextBox1_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }
    }
}

