﻿using System;
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
        public DaoCliente(string banco)
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
    }

}
