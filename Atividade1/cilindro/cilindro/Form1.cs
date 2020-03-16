using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace cilindro
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        

        private void button1_Click(object sender, EventArgs e)
        {
            double altura, raio, volume;
            if (double.TryParse(textBox1.Text, out altura) && double.TryParse(textBox2.Text, out raio))
            {

                altura = Double.Parse(textBox1.Text);
                raio = Double.Parse(textBox2.Text);
                volume = raio * raio * altura * 3.1415926;

                textBox3.Text = volume.ToString("N2");
            }
            else
                MessageBox.Show("Elemento invalido");
            
        }

        
    }
}
