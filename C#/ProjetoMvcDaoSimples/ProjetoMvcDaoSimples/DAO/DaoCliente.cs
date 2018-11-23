using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProjetoMvcDaoSimples.MODEL;
using MySql.Data.MySqlClient;



namespace ProjetoMvcDaoSimples.DAO
{
    class DaoCliente
    {
        MySqlConnection Conexao;
        public DaoCliente()
        {
           Conexao = new MySqlConnection("Server=DESKTOP-R4FHL82;Database=bancodao1;Uid=Lucas;Pwd=GA344IGGBAL");
        }
        public void Create(Cliente Cliente)
        {
            string comandoSql = "Insert into Cliente (nome,apelido,cpf,endereco,valor) values(@nome,@apelido,@cpf,@endereco,@valor)";

            MySqlCommand comando = new MySqlCommand(comandoSql,Conexao);

            comando.Parameters.Add("@nome",MySqlDbType.VarChar).Value = Cliente.nome;
            comando.Parameters.Add("@apelido",MySqlDbType.VarChar).Value = Cliente.apelido;
            comando.Parameters.Add("@cpf", MySqlDbType.VarChar).Value = Cliente.cpf;
            comando.Parameters.Add("@endereco", MySqlDbType.VarChar).Value = Cliente.endereco;
            comando.Parameters.Add("@valor", MySqlDbType.Double).Value = Convert.ToDouble(Cliente.valor);

            try
            {
                Conexao.Open();
                comando.ExecuteNonQuery();
            }
            catch
            {

            }
            finally
            {
                Conexao.Close();
            }
        }

        public Cliente consultaID(Cliente Cliente)
        {
            string comandoSql = "select * from cliente where id ='" + Cliente.id+ "'";
            MySqlCommand comando = new MySqlCommand(comandoSql, Conexao);

            try
            {
                Conexao.Open();
                MySqlDataReader rd = comando.ExecuteReader();
                while (rd.Read())
                {
                    Cliente.id = Convert.ToInt32(rd["id"]);
                    Cliente.nome = Convert.ToString(rd["nome"]);
                    Cliente.apelido = Convert.ToString(rd["apelido"]);
                    Cliente.cpf = Convert.ToString(rd["cpf"]);
                    Cliente.endereco = Convert.ToString(rd["endereco"]);
                    Cliente.valor = Convert.ToDouble(rd["valor"]);
                }
                
                if(Cliente.nome == "" || Cliente.apelido == "" || Cliente.cpf == "" || Cliente.endereco == "")
                {
                    Cliente = null;
                    return Cliente;
                }
                else
                {
                    return Cliente;
                }
            }
            catch
            {
                return null;
            }
            finally
            {
                Conexao.Close();
            }
        }
    }

}
