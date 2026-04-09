using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace att7
{
    internal class moeda
    {
        double reais;
        double dolares;

        public void pedirDolares()
        {
            Console.WriteLine("Digite um valor em Doláres");
            dolares = double.Parse(Console.ReadLine());
        }
        public void convertor()
        {
            reais = dolares * 5;
        }
        public void exibirReais()
        {
            Console.WriteLine("Seu valor em Dolares{0}, Valor convertido em Reais{1}",dolares,reais);
        }
    }
}
