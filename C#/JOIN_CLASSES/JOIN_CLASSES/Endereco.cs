using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JOIN_CLASSES
{
    class Endereco
    {
        public string rua { get; set; }
        public string cep { get; set; }

        public Endereco()
        {
            cep = "0";
            rua = "";
        }
        
    }
}
