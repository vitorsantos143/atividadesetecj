using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace att9
{
    internal class leitor
    {
        string nome;
        int idade;

        public void pedirNome()
        {
            Console.WriteLine("Digite seu nome");
            nome = Console.ReadLine();
        }
        public void pedirIdade()
        {
            Console.WriteLine("Digite sua idade:");
            idade = int.Parse(Console.ReadLine());
        }
        public void boasVindas()
        {
            Console.WriteLine("Olá {0}, sua idade é {1}",nome,idade);
            Console.ReadKey();
        }
    }
}
