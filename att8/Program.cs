using Exercicio8;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Versioning;
using System.Text;
using System.Threading.Tasks;

namespace att8
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ante conta = new ante();
            Console.WriteLine("Digite um numero");
            conta.alterarPosicao(int.Parse(Console.ReadLine()));
        }
    }
}
