﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoMvcDaoSimples.MODEL
{
    class Cliente
    {
        public int id { get; set; }
        public string nome { get; set; }
        public string apelido { get; set; }
        public string cpf { get; set; }
        public string endereco { get; set; }
        public double valor { get; set; }
    }
}
