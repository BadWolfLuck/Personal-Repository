using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using MySql.Data.MySqlClient;

namespace WebAulaMasterPage
{
    public partial class frmCadastro : System.Web.UI.Page
    {
        //Criação de todos as variáveis para trabalhar com o banco de dados MySql
        private MySqlConnection objCnx = new MySqlConnection();
        private MySqlCommand objCmd = new MySqlCommand();
        private MySqlDataReader objDados;

        protected void Page_Load(object sender, EventArgs e)
        {
            try
            {
                objCnx.ConnectionString = "Server=DESKTOP-R4FHL82;Database=bancodao1;Uid=Lucas;Pwd=GA344IGGBAL";
                objCnx.Open();
            }
            catch (Exception erro)
            {
                lblMsgErro.Text = erro.Message;
            }
        }
        protected void btnVoltar_Click(object sender, EventArgs e)
        {
            Response.Redirect("Default.aspx");
        }

        protected void btnIncluir_Click(object sender, EventArgs e)
        {
            try
            {
                string strSQL = "Insert into AulaWeb (nome,email,usuario,senha) values (";
                strSQL += "'" + txtNome.Text + "'";
                strSQL += "'" + txtEmail.Text + "'";
                strSQL += "'" + txtUsuario.Text + "'";
                strSQL += "'" + txtSenha.Text + "')";

                //Execução da instrução SQL no Banco de Dados
                objCmd.Connection = objCnx;
                objCmd.CommandText = strSQL;
                objCmd.ExecuteNonQuery();
                lblMsgErro.Text = "Registro incluído com sucesso!";
            }
            catch(Exception erro)
            {
                lblMsgErro.Text = erro.Message;
            }
        }
    }
}