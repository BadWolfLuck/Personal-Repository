using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVC_2
{
    class Cliente
    {
        public string nome { get; set; }
        public float cpf { get; set; }
        public float limite { get; set; }
        public int idade { get; set; }

        public Venda v1;
        public Cliente()
        {
            //Instanciando a classe venda....ERRADO EU ACHO........
            v1 = new Venda();
            //Zerando as variaveis.
            nome = "";
            cpf = idade = 0;
            limite = 0;

        }
        /*public Venda[] Pro = new Venda[3];

        public Cliente()
        {
            for (int i=0;i<3;i++)
            {
                Pro[i] = new Venda();
            }
        }*/
    }
}
