using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Atvidade7
{
    public partial class frmEx7 : Form
    {
        public frmEx7()
        {
            InitializeComponent();
        }

        private void bttExecut_Click(object sender, EventArgs e)
        {
            string entrada="";
            string nome = "";
            int N;
            int tamanho;

            entrada = Interaction.InputBox("Quantia de Nomes:", "Informe a quantidade de nomes:");
            if(int.TryParse(entrada, out N))
            {
                if (N == 0)
                {
                    for(var x=0; x < 10; x++)
                    {
                        entrada = Interaction.InputBox("Nome: " +(x+1) ,"Informe o nome: ");
                        nome = entrada.Replace(" ", "");
                        tamanho = nome.Length;
                        listNomes.Items.Add("O nome " + entrada + " tem " + tamanho + " caracteres.");
                    
                    }
                }
                else
                    {
                    for(var x=0; x < N; x++)
                    {
                        entrada = Interaction.InputBox("Nome: " +(x+1) ,"Informe o nome: ");
                        nome = entrada.Replace(" ", "");
                        tamanho = nome.Length;
                        listNomes.Items.Add("O nome " + entrada + " tem " + tamanho + " caracteres.");
                    
                    }
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            listNomes.Items.Remove(listNomes.SelectedItem);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            listNomes.Items.Clear();
        }
    }
}
