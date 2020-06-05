using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.VisualBasic;
using System.Collections;

namespace Atvidade7
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int[] Vetor = new int[20];
            string auxiliar = "";
            string valor = "";

            for (var x = 0; x < 20; x++)
            {
                valor = Interaction.InputBox("Digite o valor na posição: "+(x+1), "Entrada de dados");
                if (valor == "") { break; }
                if (int.TryParse(valor, out Vetor[x]))
                {
                    auxiliar = Vetor[x].ToString() + "\n" + auxiliar;
                }
                else {
                    MessageBox.Show(auxiliar);
                    x--;
                }
            
            }
            MessageBox.Show(auxiliar);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int[] Vetor = new int[20];
            string auxiliar = "";
            string valor = "";

            for (var x = 0; x < 20; x++)
            {
                valor = Interaction.InputBox("Digite o valor na posição: " + (x + 1), "Entrada de dados");
                if (valor == "") { break; }

                if (!int.TryParse(valor, out Vetor[x]))
                {
                    MessageBox.Show("Digite elemento valido");
                    x--;
                }
            }
            Array.Reverse(Vetor);

            for(var x = 0; x < 20; x++)
            {
                auxiliar = auxiliar + "\n" + Vetor[x];
            }
            MessageBox.Show(auxiliar);

            }

        private void button3_Click(object sender, EventArgs e)
        {
            double[] preco = new double[10];
            int[] quantidade = new int[10];
            double fatmes=0, fat=0;            
            string entrada = "";
            string auxiliar = "";

            for (var x =0; x < 10; x++)
            {
                entrada = Interaction.InputBox("Digite o preço na posição: " + (x + 1), "Entrada de dados;");
                if (entrada == "") { break; }

                if (!double.TryParse(entrada, out preco[x]))
                {
                    MessageBox.Show("Digite elemento valido");
                    x--;
                }
                else
                {
                    entrada = Interaction.InputBox("Digite quantidade na posição: " + (x + 1), "Entrada de dados;");
                    if (entrada == "") { break; }
                    if (!int.TryParse(entrada, out quantidade[x]))
                    {
                        MessageBox.Show("Digite elemento valido");
                        x--;

                    }
                    else
                    {
                        fat = quantidade[x] * preco[x];
                        fatmes += fat; 
                        auxiliar += "\n" +"quantidade: " + quantidade[x] + " Preço: " + preco[x] +" Faturamento: " + fat;

                    }
                }

            }
            auxiliar += "\n" + "Faturamento total: " + fatmes;

           MessageBox.Show(auxiliar);
        }

        private void bttEx4_Click(object sender, EventArgs e)
        {
            string[] Alunos = { "Viviane", "André", "Hélio", "Denise",
                                "Junior", "Leonardo", "Jose", "Nelma", "Tobby" };
            Int32 I, Total = 0; 
            Int32 N = Alunos.Length; 
            for (I = 0; I < N - 1; I++) { Total += Alunos[I].Length; }
            MessageBox.Show("Resposta: " + Total + " = c", "Atividade 4");
        }

        private void bttEx5_Click(object sender, EventArgs e)
        {
            ArrayList myAL = new ArrayList();
            myAL.Add("Ana");
            myAL.Add("André");
            myAL.Add("Débora");
            myAL.Add("Fátima");
            myAL.Add("João");
            myAL.Add("Janete");
            myAL.Add("Otávio");
            myAL.Add("Marcelo");
            myAL.Add("Pedro");
            myAL.Add("Thais");

            myAL.Sort();
            for(var x = 0; x<myAL.Count; x++)
            {
                if (!Equals("Otávio", myAL[x].ToString()))
                MessageBox.Show(myAL[x].ToString());
            }
        }
    }
}
