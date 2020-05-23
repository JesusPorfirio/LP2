using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PMenus
{
    public partial class frmExercicio4 : Form
    {
        public frmExercicio4()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int cont = 0;
            for (var x = 0; x < rchtxtTexto.Text.Length; x++) 
            {
                if (Char.IsNumber(rchtxtTexto.Text[x]))
                    cont += 1;
            }
            MessageBox.Show("Caracteres Númericos: " + cont);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int x = 0;
            while(x<rchtxtTexto.Text.Length)
            {
                if (Char.IsWhiteSpace(rchtxtTexto.Text[x]))
                {
                    MessageBox.Show("Primeiro Caracter Branco: " + (x + 1));
                    break;
                }

                x += 1;
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            int cont = 0;

            foreach(char c in rchtxtTexto.Text)
            {
                if (Char.IsLetter(c))
                    cont += 1;
            }

            MessageBox.Show("Caracteres Alfabeticos: " + (cont));

        }
    }
}
