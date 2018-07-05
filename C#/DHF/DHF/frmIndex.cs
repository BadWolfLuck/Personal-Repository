using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DHF
{
    public partial class frmIndex : Form
    {
        public frmIndex()
        {
            InitializeComponent();
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void físicoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmCadastroFisico cadastro = new frmCadastroFisico();
            cadastro.Show();
        }

        private void jurídicoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmCadastroJuridico cadastro = new frmCadastroJuridico();
            cadastro.Show();
        }

        private void fornecedorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmCadastroForncedor cadastro = new frmCadastroForncedor();
            cadastro.Show();
        }
    }
}
