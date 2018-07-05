using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Banco
{
    public partial class Form1 : Form
    {
        Conta c1;

        public Form1()
        {
            c1 = new Conta();
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {



        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
          
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "")
            {
                MessageBox.Show("Digite seu nome!", "Erro!!!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {
                c1.nome = textBox1.Text;
            }

            if (maskedTextBox1.Text == "")
            {
                MessageBox.Show("Erro digite o numero da conta", "Erro!!!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {
                c1.num = Convert.ToInt32(maskedTextBox1.Text);
            }
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (textBox3.Text == "")
            {
                MessageBox.Show("Erro digite alguma coisa!", "Erro!!!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {
                c1.Deposito(Convert.ToDouble(textBox3.Text));
            }
        }

        private void label5_Click_1(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void textBox7_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox8_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {
            //Get.....
            textBox7.Text =c1.nome;
            textBox8.Text = Convert.ToString(c1.num);
            textBox5.Text = Convert.ToString(c1.Get_Saldo());
            textBox6.Text = Convert.ToString(c1.limite);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (textBox4.Text == "")
            {
                MessageBox.Show("Erro digite alguma coisa!", "Erro!!!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {
                c1.Mais_limite(Convert.ToDouble(textBox4.Text));
            }

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (textBox4.Text == "")
            {
                MessageBox.Show("Erro digite alguma coisa!", "Erro!!!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {
                c1.Menos_limite(Convert.ToDouble(textBox4.Text));
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void maskedTextBox1_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void btn_Limpar_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            maskedTextBox1.Text = "";
            textBox3.Text = "";
            textBox4.Text = "";
        }

        private void btn_Sair_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Você realmente deseja sair?","Encerrar Aplicação?", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void groupBox3_Enter(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (textBox3.Text == "")
            {
                MessageBox.Show("Erro digite alguma coisa!", "Erro!!!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {
                c1.Saque(Convert.ToDouble(textBox3.Text));
            }
        }

        private void lbl_nome_Click(object sender, EventArgs e)
        {

        }
    }
}
