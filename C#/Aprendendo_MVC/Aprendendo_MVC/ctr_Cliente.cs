using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aprendendo_MVC
{
    class ctr_Cliente
    {
        Cliente C = new Cliente();
        public void Add(Cliente cli)
        {
            //SQL insert cliente from (cli.nome,cli.RG.....);
            C = cli;
        }
        public Cliente Add1(Cliente c1)
        {
            return c1;
        }
        public Cliente Consultar(Cliente cli)
        {
            //Cliente aux = new Cliente();
            //aux =SQL select cliente frim(cli.CPF.....);
            cli = C;
            return cli;
        }
        public Cliente Excluir(Cliente cli)
        {
            Cliente vazio = new Cliente();
            return vazio;
        }
        public Cliente Alterar(Cliente cli)
        {
            return cli;
        }
        public void Vender(Cliente C, Venda V)
        {

        }
    }
}
