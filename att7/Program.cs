using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace att7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            moeda converter = new moeda();
            converter.pedirDolares();
            converter.convertor();
            converter.exibirReais();
        }
    }
}
