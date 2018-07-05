using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MENU
{
    public partial class frmSomatorio : Form
    {
        public frmSomatorio()
        {
            InitializeComponent();
        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            if(MessageBox.Show("Você realmente deseja voltar?", "Voltar para aba principal?",MessageBoxButtons.YesNo,MessageBoxIcon.Question)== DialogResult.Yes)
            {
                Close();
            }
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            lblResultado.Text = Convert.ToString(Convert.ToDouble(txtBox1.Text)+Convert.ToDouble(txtBox2.Text));
        }
    }
}
