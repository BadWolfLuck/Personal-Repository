using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CADASTRO1
{
    class Cliente
    {
        public string codigo { get; set; }
        public string nome {get; set;}
        public double cpf {get; set;}
        public double rg { get; set;}
        
        public Cliente()
        {
            nome = codigo = "";
            cpf = rg = 0;
        }
    }
}
