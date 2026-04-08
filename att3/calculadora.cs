using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace att3
{
    internal class calculadora
    {
        int n1;
        int n2;
        int resultado;

        public void pedirNum1()
        {
            Console.WriteLine("Digite o primeiro numero");
            n1 = int.Parse(Console.ReadLine());
        }
        public void pedirNum2()
        {
            Console.WriteLine("digite o segundo numero");
            n2 = int.Parse(Console.ReadLine());
        }
        public void calculo()
        {
            resultado = n1 + n2;
        }
        public void exibir()
        {
            Console.WriteLine("O resultado é:" + resultado);
        }
    }
}
