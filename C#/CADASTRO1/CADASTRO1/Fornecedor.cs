using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CADASTRO1
{
    class Fornecedor
    {
        public string codigo { get; set; }
        public string nome { get; set; }
        public double cnpj { get; set; }
        public double ie { get; set; }

        public Fornecedor()
        {
            nome = codigo = "";
            cnpj = ie = 0;
        }
    }
}
