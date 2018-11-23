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
    public partial class frmAlterar : Form
    {
        Cliente Cliente;
        ctrCliente ctrCliente;
        public frmAlterar()
        {
            InitializeComponent();
        }

        private void frmAlterar_Load(object sender, EventArgs e)
        {

        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnConsultar_Click(object sender, EventArgs e)
        {
            if (txtID.Text == "")
            {
                MessageBox.Show("Digite um ID Por Favor!!");
            }
            else
            {
                Cliente = new Cliente();
                ctrCliente = new ctrCliente();
                try
                {
                    Cliente.id = Convert.ToInt32(txtID.Text);
                    Cliente = ctrCliente.Consultar(Cliente);
                    atualizarTextBox();
                }
                catch
                {
                    MessageBox.Show("Digite Somente Números");
                }
            }
            void atualizarTextBox()
            {
                if (Cliente == null)
                {
                    MessageBox.Show("Cliente não encontrado");
                }
                else
                {
                    txtNome.Text = Cliente.nome;
                    txtApelido.Text = Cliente.apelido;
                    txtCPF.Text = Cliente.cpf;
                    txtEndereco.Text = Cliente.endereco;
                    txtValor.Text = Convert.ToString(Cliente.valor);
                }
            }
        }

        private void btnAlterar_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Você realmente deseja alterar esses valores?", "Alterar Valores", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                MessageBox.Show("Valores alterados com seucesso", "Valores Alterados",MessageBoxButtons.OK,MessageBoxIcon.Information);
            }
            else
            {

            }
        }
    }
}

