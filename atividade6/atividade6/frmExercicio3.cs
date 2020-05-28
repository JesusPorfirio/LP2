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
    public partial class frmExercicio3 : Form
    {
        public frmExercicio3()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string frase = txtFrase.Text.Replace(" ", "");
            string fraseinv = "";
            char[] reverso = frase.ToCharArray();
            int tamanho = frase.Length;

            if (tamanho < 50)
            {

                frase = frase.ToLower();
                Array.Reverse(reverso);

                foreach (char letra in reverso)
                { fraseinv = fraseinv + letra.ToString(); }
                if (string.Compare(frase, fraseinv, true) == 0)
                {
                    txtResposta.Text = "sim";
                }
                else
                    txtResposta.Text = "Não";
            }
            else
                MessageBox.Show("Frase possui mais de 50 caracteres!");
        }
    }
}
