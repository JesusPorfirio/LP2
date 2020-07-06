using System;
using System.Data.SqlClient;
using System.Windows.Forms;
namespace PAluno
{
    public partial class frmPrincipal : Form
    {
        public static SqlConnection conexao;

        public frmPrincipal()
        {
            InitializeComponent();
        }

        private void frmPrincipal_Load(object sender, EventArgs e)
        {
            try
            {
                conexao = new SqlConnection("Data Source=LAPTOP-KRCMJ4GT\\SQLEXPRESS;Initial Catalog=LP2;Integrated Security=True");
                conexao.Open();
            }
            catch (SqlException ex)
            {
                MessageBox.Show("Erro de SQL" + ex.Message);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro geral" + ex.Message);
            }
        }

        private void sairToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void cidadeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmCidade frmCid = new frmCidade();
            frmCid.MdiParent = this;
            frmCid.WindowState = FormWindowState.Maximized;
            frmCid.Show();

        }

        private void alunoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Aluno frmAlu = new Aluno();
            frmAlu.MdiParent = this;
            frmAlu.WindowState = FormWindowState.Maximized;
            frmAlu.Show();
        }

        private void sobreToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmSobre frmSob = new frmSobre();
            frmSob.MdiParent = this;
            frmSob.WindowState = FormWindowState.Maximized;
            frmSob.Show();
        }


    }
}
