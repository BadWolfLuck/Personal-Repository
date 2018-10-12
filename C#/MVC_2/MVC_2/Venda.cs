using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVC_2
{
    class Venda
    {
        public int codigo { get; set; }
        public int quantidade { get; set; }
        public double valor { get; set; }
        
        public Venda()
        {
            codigo = quantidade = 0;
            valor = 0;
        }
    }
}
