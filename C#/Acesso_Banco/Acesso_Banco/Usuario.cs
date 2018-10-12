using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Acesso_Banco
{
    class Usuario
    {
        int id;
        string nome;
        string cpf;

        public Usuario()
        {
            id = 0;
            nome = "";
            cpf = "00000000000";
        }
        public void SetNome(string x)
        {
            nome = x;
        }
        public string GetNome()
        {
            return nome;
        }
        public void SetCpf(string x)
        {
            cpf = x;
        }
        public string GetCpf()
        {
            return cpf;
        }
        public void SetId(int x)
        {
            id = x;
        }
        public int GetId()
        {
            return id;
        }

    }
}
