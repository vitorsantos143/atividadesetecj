using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace att5
{
    internal class conversor
    {
        double C;
        double F;

        public void pedirC()
        {
            Console.WriteLine("Digite uma temperatura em Celsius para converter:");
            C = double.Parse(Console.ReadLine());
        }
        public void calculo()
        {
            F = C * 9 / 5 + 32;
         
        }
        public void exibirF()
        {
      
            Console.WriteLine("Temperatura em C{0}, Convertida{1}",C,F);
    
        }
    }
}
