using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;


namespace Acesso_Banco
{
    public partial class frmCadastro : Form
    {
        Usuario Usuario;
        public frmCadastro()
        {
            InitializeComponent();
            Usuario = new Usuario();

        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            /*
            Usuario.SetNome(txtNome.Text);
            Usuario.SetCpf(txtNome.Text);
            Usuario.SetId(i);
            i += 1;
            */

            int i = 0;

            var connString = "Server=DESKTOP-R4FHL82;Database=bancomvc;Uid=Lucas;Pwd=GA344IGGBAL";
            var connection = new MySqlConnection(connString);
            var command = connection.CreateCommand();
            var consulta = connection.CreateCommand();

            try
            {
                connection.Open();
                if (connection.State == ConnectionState.Open)
                {
                    MessageBox.Show("Conectado ao banco");
                    if (txtNome.Text != "" && txtCPF.Text != "")
                    {
                        command.CommandText = "INSERT INTO USUARIO (NOME,CPF) VALUES('" + txtNome.Text + "','" + txtCPF.Text + "')";
                        command.ExecuteNonQuery();
                        MessageBox.Show("Dados Salvos com sucesso");
                        //Zerando as text box;
                        txtNome.Text = txtCPF.Text = "";
                        Close();
                    }
                    else
                    {
                        MessageBox.Show("Preencha todos os campos por favor.");
                    }
                }
            }
            catch
            {
                if (connection.State == ConnectionState.Closed)
                {
                    MessageBox.Show("Não foi possível acessar o banco.");
                }
                else
                {
                    MessageBox.Show("Erro ao inserir os dados no banco");
                }
            }
            finally
            {
                if (connection.State == ConnectionState.Open)
                {
                    connection.Close();
                }
                /*DialogResult dialogResult = MessageBox.Show("Deseja cadatrar outra pessoa?", "Continuar cadastrando?", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    i = 0;
                }
                else if (dialogResult == DialogResult.No)
                {
                    i += 1;
                }
                */
            }




        }
    }
}
