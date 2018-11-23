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
    public partial class frmConsulta : Form
    {
        Cliente Cliente;
        ctrCliente ctrCliente;
        List<Cliente> lstCliente; 
        public frmConsulta()
        {
            InitializeComponent();
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
            
        }
        private void atualizarTextBox()
        {
            if (Cliente == null)
            {
                MessageBox.Show("Cliente não encontrado");
            }
            else
            {
                lblNome.Text = Cliente.nome;
                lblApelido.Text = Cliente.apelido;
                lblCPF.Text = Cliente.cpf;
                lblEndereco.Text = Cliente.endereco;
                lblValor.Text = Convert.ToString(Cliente.valor);
            }
        }

        private void l_Load(object sender, EventArgs e)
        {

        }

        private void btnConsultar_Enter(object sender, EventArgs e)
        {
            
        }

        private void btnConsultar_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(e.KeyChar == 13)
            {
                //btnConsultar_Click();
                MessageBox.Show("Era pra funcionar mas não vai rolar");
            }
        }
    }
}
