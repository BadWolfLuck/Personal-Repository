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
    public partial class frmCadastroFisico : Form
    {
        public frmCadastroFisico()
        {
            InitializeComponent();
        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            txtboxNome.Text = txtboxRG.Text = txtboxCPF.Text = txtboxBairro.Text = txtboxCidade.Text = txtboxLogradouro.Text = txtboxNum.Text = "";
        }

        private void txtboxLogradouro_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
