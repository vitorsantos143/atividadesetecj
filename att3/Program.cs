using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace att3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            calculadora soma = new calculadora();
            soma.pedirNum1();
            soma.pedirNum2();
            soma.calculo();
            soma.exibir();
        }
    }
}
