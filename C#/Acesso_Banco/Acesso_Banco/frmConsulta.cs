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
    public partial class frmConsulta : Form
    {
        Usuario Usuario;
        public frmConsulta()
        {
            InitializeComponent();
            Usuario = new Usuario();
        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void frmConsulta_Load(object sender, EventArgs e)
        {

        }

        private void btnConsultarNome_Click(object sender, EventArgs e)
        {
            var connString = "Server=DESKTOP-R4FHL82;Database=bancomvc;Uid=Lucas;Pwd=GA344IGGBAL";
            var connection = new MySqlConnection(connString);
            var command = connection.CreateCommand();

            try
            {
                connection.Open();
                if (connection.State == ConnectionState.Open)
                {
                    MessageBox.Show("Conectado ao banco");
                    if (txtConsultarNome.Text != "")
                    {
                        command.CommandText = "SELECT nome FROM USUARIO WHERE NOME LIKE '%'" + txtConsultarNome.Text + "'%')";
                        MySqlDataReader drNome;
                        drNome = command.ExecuteReader();
                        drNome.Read();
                        lblNome.Text = drNome.GetString(0);
                        MessageBox.Show("Dados obtidos com sucesso");
                        //Zerando as text box;
                        txtConsultarNome.Text = "";


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
                Close();
            }
        }
    }
}
