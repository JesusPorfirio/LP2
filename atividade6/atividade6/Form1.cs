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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void exercicio1ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmExercicio1 frmEx1 = new frmExercicio1();
            frmEx1.Show(); 
        }

        private void exercicio2ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmExercicio2 frmEx2 = new frmExercicio2();
            frmEx2.Show();

        }

        private void exercicio3ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmExercicio3 frmEx3 = new frmExercicio3();
            frmEx3.Show();

        }

        private void exercicio4ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmExercicio4 frmEx4 = new frmExercicio4();
            frmEx4.Show();

        }

        private void closeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
