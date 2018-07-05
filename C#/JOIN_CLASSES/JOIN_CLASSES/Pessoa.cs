using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JOIN_CLASSES
{
    class Pessoa
    {
        public string Nome { get; set; }
        public double CPF { get; set; }
        public Endereco End;

        public Pessoa()
        {
            Nome = "";
            CPF = 0;
            End = new Endereco();
        }
        public Pessoa(string xNome, double xCPF)
        {
            Nome = xNome;
            CPF = xCPF;
            End = new Endereco();
        }
        public void addEnd(string xrua,string xcep)
        {
            End.rua = xrua;
            End.cep = xcep;
        }
        /*public void addEnd(string xcep,string xrua)
        //cep foi convertido de double para string(metodo foi inutilizado)
        {
            End.rua = xrua;
            End.cep = xcep;
        }*/
        public void addEnd(Endereco xend)
        {
            End = xend;
        }
        public Endereco retEnd()
        {
            return End;
        }
    }
}
