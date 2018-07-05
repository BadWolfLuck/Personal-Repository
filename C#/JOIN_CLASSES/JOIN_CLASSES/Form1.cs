using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace JOIN_CLASSES
{
    public partial class Form1 : Form
    {
        Pessoa P1;
        Endereco[] E;
        public Form1()
        {
            InitializeComponent();
            P1 = new Pessoa("Padrão",10);
            //Criando vetor de endereco;
            int qnt = 3;
            E = new Endereco[qnt];
            /*
            E[0] = new Endereco();
            E[1] = new Endereco();
            E[2] = new Endereco();
            */
            //int i;
            for (int i = 0; i <= qnt - 1; i++)
            { 
                E[i] = new Endereco();
            }
            
            //Fim vetor endereco;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void btnGravar_Click(object sender, EventArgs e)
        {
            P1.Nome = txtboxNome.Text;
            try
            {
                P1.CPF = Convert.ToDouble(txtboxCPF.Text);
                txtboxCPF.BackColor = Color.White;
            }
             catch
            {
                txtboxCPF.BackColor = Color.Red;
                MessageBox.Show("Digite somente numeros!!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            P1.End.rua = txtboxRua.Text;
            //P1.End.cep = Convert.ToInt32(txtboxCEP.Text);
            P1.End.cep = txtboxCEP.Text;
            txtboxCEP.Text = txtboxCPF.Text = txtboxNome.Text = txtboxRua.Text = "";
        }

        private void btnExibir_Click(object sender, EventArgs e)
        {
            lblNome.Text = P1.Nome;
            lblCPF.Text = Convert.ToString(P1.CPF);
            lblRua.Text = P1.End.rua;
            lblCEP.Text = Convert.ToString(P1.End.cep);
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            lblCEP.Text = lblCPF.Text = lblNome.Text = lblRua.Text = "";
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnTeste_Click(object sender, EventArgs e)
        {
            Endereco aux = new Endereco();
            aux.rua = "Badejo";
            aux.cep = "13285616";
            //isso...
            //P1.End.rua = aux.rua;
            //P1.End.cep = aux.cep;
            ///ou...
            P1.End = aux;
            ///gg izi.....
        }

        private void btnTeste1_Click(object sender, EventArgs e)
        {
            P1.addEnd("Cachalote", "132222");
        }

        private void btnTeste2_Click(object sender, EventArgs e)
        {
            Endereco aux = new Endereco();
            P1.addEnd(aux);
        }

        private void btnGravar1_Click(object sender, EventArgs e)
        {
            E[0].rua = txtboxRua1.Text;
            E[0].cep = txtboxCEP1.Text;

            E[1].rua = txtboxRua2.Text;
            E[1].cep = txtboxCEP2.Text;

            E[2].rua = txtboxRua3.Text;
            E[2].cep = txtboxCEP3.Text;

            txtboxRua1.Text = txtboxRua2.Text = txtboxRua3.Text
            = txtboxCEP1.Text = txtboxCEP2.Text = txtboxCEP3.Text = "";
        }

        private void btnExibir1_Click(object sender, EventArgs e)
        {
            txtboxRua1.Text = E[0].rua;
            txtboxCEP1.Text = E[0].cep;

            txtboxRua2.Text = E[1].rua;
            txtboxCEP2.Text = E[1].cep;

            txtboxRua3.Text = E[2].rua;
            txtboxCEP3.Text = E[2].cep;
        }
    }
}
