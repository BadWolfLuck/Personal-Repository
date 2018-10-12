using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Acesso_Banco
{
    public partial class frmPrincipal : Form
    {
        frmSplash frmSplash;
        public frmPrincipal()
        {
            InitializeComponent();
        }

        private void frmPrincipal_Load(object sender, EventArgs e)
        {

        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnConsultar_Click(object sender, EventArgs e)
        {
            frmConsulta frmConsulta = new frmConsulta();
            frmConsulta.Show();
        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            frmCadastro frmCadastro = new frmCadastro();
            frmCadastro.Show();
        }
    }
}
