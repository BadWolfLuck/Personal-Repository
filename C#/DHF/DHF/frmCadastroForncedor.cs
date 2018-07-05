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
    public partial class frmCadastroForncedor : Form
    {
        public frmCadastroForncedor()
        {
            InitializeComponent();
        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {

        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            txtboxBairro.Text = txtboxCidade.Text = txtboxCNPJ.Text = txtboxIE.Text = txtboxLogradouro.Text = txtboxNome.Text = txtboxNum.Text = "";
        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
