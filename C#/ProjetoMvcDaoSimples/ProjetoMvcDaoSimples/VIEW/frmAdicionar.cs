using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ProjetoMvcDaoSimples.CONTROL;
using ProjetoMvcDaoSimples.MODEL;

namespace ProjetoMvcDaoSimples.VIEW
{
    public partial class frmAdicionar : Form
    {
        ctrCliente ctrCliente;
        Cliente Cliente;
        public frmAdicionar()
        {
            InitializeComponent();
        }

        private void frmAdicionar_Load(object sender, EventArgs e)
        {

        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            if(txtNome.Text == "" || txtApelido.Text == ""||txtCPF.Text==""||txtEndereco.Text==""||txtValor.Text=="")
            {
                MessageBox.Show("Você não preencheu todos os campos.\n Faça corretamente e tente novamente.");
            }
            else
            {
                Cliente = new Cliente();
                ctrCliente = new ctrCliente();
                Cliente.nome = txtNome.Text;
                Cliente.apelido = txtApelido.Text;
                Cliente.cpf = txtCPF.Text;
                Cliente.endereco = txtEndereco.Text;
                Cliente.valor = Convert.ToDouble(txtValor.Text);
                ctrCliente.Novo_Cliente(Cliente);
            }
            
        }
    }
}
