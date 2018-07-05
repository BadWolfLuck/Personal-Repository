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
    public partial class frmCadastroJuridico : Form
    {
        public frmCadastroJuridico()
        {
            InitializeComponent();
        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            txtboxBairro.Text = txtboxCidade.Text = txtboxCNPJ.Text = txtboxIE.Text = txtboxLogradouro.Text = txtboxNome.Text = txtboxNum.Text = "";

        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void txtboxCNPJ_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtboxIE_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtboxNome_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
