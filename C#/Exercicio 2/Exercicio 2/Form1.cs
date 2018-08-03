using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Exercicio_2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btn_Sair_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void txtBox_CustoFabrica_TextChanged(object sender, EventArgs e)
        {

        }

        private void lbl_CustoFinal_Click(object sender, EventArgs e)
        {

        }

        private void btn_Limpar_Click(object sender, EventArgs e)
        {
            txtBox_CustoFabrica.Text = lbl_CustoFinal.Text = "";
        }

        private void btn_Calcular_Click(object sender, EventArgs e)
        {
            double vf, cf, imposto, distribuidor;
            cf = Convert.ToDouble(txtBox_CustoFabrica.Text);
            imposto = cf * 0.45;
            distribuidor = cf * 0.28;
            vf = cf + imposto + distribuidor;
            lbl_CustoFinal.Text = vf.ToString();
        }
    }
}
