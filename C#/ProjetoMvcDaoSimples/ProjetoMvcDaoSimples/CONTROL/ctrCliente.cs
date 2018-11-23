﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProjetoMvcDaoSimples.MODEL;
using ProjetoMvcDaoSimples.DAO;

namespace ProjetoMvcDaoSimples.CONTROL
{
    class ctrCliente
    {
        DaoCliente DaoCliente;
        List<Cliente> lista_cliente;

        //public ctrCliente(string banco)
        public ctrCliente()
        {
            DaoCliente = new DaoCliente();
            lista_cliente = new List<Cliente>();
        }
        public void Novo_Cliente(Cliente cliente)
        {
            DaoCliente.Create(cliente);
        }
        public Cliente Consultar(Cliente Cliente)
        {
            return DaoCliente.consultaID(Cliente);
        }
    }
}
