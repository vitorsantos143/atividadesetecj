using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace att6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            potencia dobrar = new potencia();
            dobrar.pedirNum();
            dobrar.calcular();
            dobrar.exibirNum();
        }
    }
}
