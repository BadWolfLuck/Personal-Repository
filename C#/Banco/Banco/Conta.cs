using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Banco
{
    class Conta
    {
        public int num { get; set; }
        public string nome;
        private double saldo;
        public double limite {get;set;}

        public Conta()
        {
            num = 0;
            nome = "";
            saldo = 0;
            limite = 100;
        }

        public void Deposito(double valor)
        {
                saldo += valor; 
        }

        public int Saque(double valor)
        {
            if (valor <= saldo + limite)
            {

                saldo -= valor;

                return 1;
            }
          
                return 0;
        }
        public double Get_Saldo()
        {
            return saldo;
        }
        public double Get_Limite()
        {
            return limite;
        }
        public void Mais_limite(double valor)
        {
            if (limite == 0)
            {
                limite = valor;
            }
            if (valor <= limite * 2)
            {
                limite += valor;
            }
        }

        public void Menos_limite(double valor)
        {
            if (valor <= limite)
            {
                limite -= valor;
            }

        }

        //Destrutor.
        // private ~Conta()
        //{
        //}
        //Fim.

    }

}