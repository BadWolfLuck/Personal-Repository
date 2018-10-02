using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Aprendendo_MVC
{
    public partial class frmCliente : Form
    {
        Cliente C1;
        List<Cliente> LC;
        List<String> Laux;

        public frmCliente()
        {
            InitializeComponent();
            C1 = new Cliente();
            Laux = new List<string>();
            LC = new List<Cliente>();
        }

        private void btn_Sair_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btn_Consultar_Click(object sender, EventArgs e)
        {
            frmConsultarCliente Exibir = new frmConsultarCliente();
            Exibir.Show();
        }

        private void btn_Comprar_Click(object sender, EventArgs e)
        {
            frmCompra Comprar = new frmCompra();
            Comprar.Show();
        }

        private void btn_Incluir_Click(object sender, EventArgs e)
        {
            //grava o que está nas text box em na classe cliente;
            ///*
            C1.nome = txtNome.Text;
            C1.idade = Convert.ToInt32(txtIdade.Text);
            C1.rg = Convert.ToSingle(txtRG.Text);
            C1.cpf = Convert.ToSingle(txtCPF.Text);
            C1.limite = Convert.ToSingle(txtLimite.Text);
            C1.endereco = txtEndereco.Text;
            //*/
            //Usando o método para que ele grave no banco.
            ctr_Cliente ctr_Cliente = new ctr_Cliente();

            ctr_Cliente.Add(C1);

            Laux.Add(txtNome.Text);

            LC.Add(ctr_Cliente.Add1(C1));
        }
        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void btn_Alterar_Click(object sender, EventArgs e)
        {
            //Verificar se existe na base de dados(Consultar).
            Le_Cliente();

            ctr_Cliente ctr_Cliente = new ctr_Cliente();
            C1 = ctr_Cliente.Alterar(C1);

            Exibir_Cliente();

        }
        public void Le_Cliente()
        {
            C1.nome = txtNome.Text;
            C1.cpf = Convert.ToInt32(txtCPF.Text);
        }
        public void Exibir_Cliente()
        {
            txtNome.Text = C1.nome;
            txtCPF.Text = Convert.ToString(C1.cpf);
        }
        public void Le_Cliente1()
        {
            ctr_Cliente XPTO = new ctr_Cliente();
            XPTO.Add(C1);
        }
        public void Exibir1_Cliente()
        {

        }

        private void btnAll_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            for (int i = 0; i < LC.Count; i++){
                listBox1.Items.Add(LC[i].nome + "" + LC[i].cpf+""+LC[i].rg);
            }
        }

        private void txtCPF_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
