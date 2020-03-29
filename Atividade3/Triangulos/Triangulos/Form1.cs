using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Triangulos
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void tiptrian_Click(object sender, EventArgs e)
        {
            double a, b, c;

            if (double.TryParse(la.Text, out a) && double.TryParse(lb.Text, out b)
                && double.TryParse(lc.Text, out c))
            { 
                a = double.Parse(la.Text); 
                b = double.Parse(lb.Text);
                c = double.Parse(lc.Text);

                if  (b - c < a && a < b + c &&  b < a + c && a - c < b && a - b < c  && c < a + b)
                {
                    if (a == b && b == c && c == a)
                    {
                        triang.Text = "triangulo equilatero";
                        imgtrian.Image = Properties.Resources.equilatero;
                    }

                    else if (a == b || b == c || c == a)
                    {
                        triang.Text = "triangulo isoceles";
                        imgtrian.Image = Properties.Resources.isoceles;
                    }

                    else if (a != b || b != c || c != a)
                    {
                        triang.Text = "triangulo escaleno";
                        imgtrian.Image = Properties.Resources.escaleno;
                    }
                }
                else
                    MessageBox.Show("dados não formam triangulo");

            }
            else
                MessageBox.Show("Escreva direito!");
        }
    }
}
