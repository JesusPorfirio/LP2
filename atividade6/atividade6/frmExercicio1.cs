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
    public partial class frmExercicio1 : Form
    {
        public frmExercicio1()
        {
            InitializeComponent();
        }

        private void bttEspacoBranco_Click(object sender, EventArgs e)
        {
            int cont = 0;
            for (var x = 0; x < rchCaixaTexto.Text.Length; x++)
            {
                if (Char.IsWhiteSpace(rchCaixaTexto.Text[x]))
                    cont++;
            }
            txtBran.Text = cont.ToString();
        }

        private void bttTotR_Click(object sender, EventArgs e)
        {

            int cont = 0, x = 0;
            while (x < (rchCaixaTexto.Text.Length))
            {

                if (rchCaixaTexto.Text[x].Equals('R') || 
                    rchCaixaTexto.Text[x].Equals('r'))
                {
                    cont++;
                }
                x++;
            }
            txtR.Text = cont.ToString();
        }

        private void bttTotPares_Click(object sender, EventArgs e)
        {
            //ssorro uopa aiai vv
            int cont = 0, x = 0;
            while (x < (rchCaixaTexto.Text.Length - 1))
            {

                if (rchCaixaTexto.Text[x].Equals(rchCaixaTexto.Text[x + 1]))
                {
                    cont++;
                }
                x++;
            }
            txtCP.Text = cont.ToString();
        }
    }
}
