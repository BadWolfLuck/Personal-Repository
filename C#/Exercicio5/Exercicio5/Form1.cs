using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Exercicio5
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            txtBatata.Text = txtCeva.Text = txtDoce.Text = txtHamburger.Text = txtRefri.Text = "0";
        }

        private void btnHamSoma_Click(object sender, EventArgs e)
        {
            int i;
            i = Convert.ToInt32(txtHamburger.Text);
            i += 1;
            txtHamburger.Text = Convert.ToString(i);

        }

        private void btnHamSub_Click(object sender, EventArgs e)
        {
            int i;
            i = Convert.ToInt32(txtHamburger.Text);
            i -= 1;
            if (i < 0)
            {
                i = 0;
            }
            txtHamburger.Text = Convert.ToString(i);
        }

        private void btnBatSoma_Click(object sender, EventArgs e)
        {
            int i;
            i = Convert.ToInt32(txtBatata.Text);
            i += 1;
            txtBatata.Text = Convert.ToString(i);
        }

        private void btnBatSub_Click(object sender, EventArgs e)
        {
            int i;
            i = Convert.ToInt32(txtBatata.Text);
            i -= 1;
            if (i < 0)
            {
                i = 0;
            }
            txtBatata.Text = Convert.ToString(i);
        }

        private void btnRefriSoma_Click(object sender, EventArgs e)
        {
            int i;
            i = Convert.ToInt32(txtRefri.Text);
            i += 1;
            txtRefri.Text = Convert.ToString(i);
        }

        private void btnRefriSub_Click(object sender, EventArgs e)
        {
            int i;
            i = Convert.ToInt32(txtRefri.Text);
            i -= 1;
            if (i < 0)
            {
                i = 0;
            }
            txtRefri.Text = Convert.ToString(i);
        }

        private void btnCevaSoma_Click(object sender, EventArgs e)
        {
            int i;
            i = Convert.ToInt32(txtCeva.Text);
            i += 1;
            txtCeva.Text = Convert.ToString(i);
        }

        private void btnCevaSub_Click(object sender, EventArgs e)
        {
            int i;
            i = Convert.ToInt32(txtCeva.Text);
            i -= 1;
            if (i < 0)
            {
                i = 0;
            }
            txtCeva.Text = Convert.ToString(i);
        }

        private void btnDoceSoma_Click(object sender, EventArgs e)
        {
            int i;
            i = Convert.ToInt32(txtDoce.Text);
            i += 1;
            txtDoce.Text = Convert.ToString(i);
        }

        private void btnDoceSub_Click(object sender, EventArgs e)
        {
            int i;
            i = Convert.ToInt32(txtDoce.Text);
            i -= 1;
            if (i < 0)
            {
                i = 0;
            }
            txtDoce.Text = Convert.ToString(i);
        }

        private void btnFinalizar_Click(object sender, EventArgs e)
        {
            Produtos P1 = new Produtos();
            double i,resultado;
            resultado = P1.Hamburger;

        }
    }
}
