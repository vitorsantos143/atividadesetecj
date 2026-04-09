using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace att6
{
    internal class potencia
    {
        int num1;
        int dobro;

        public void pedirNum()
        {
            Console.WriteLine("Digite um numero:");
            num1 = int.Parse(Console.ReadLine());
        }
        public void calcular()
        {
            dobro = num1 * 2;
        }
        public void exibirNum()
        {
            Console.WriteLine("Numero {0}, Dobro{1}",num1,dobro);
        }
    }
}
