using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace att2
{
    internal class whatts
    {
        string nome;
        public void pedirNome()
                   
        {
            Console.WriteLine("Digite seu nome");
            nome = Console.ReadLine();
        }
        public void exibirNome()
        {
            Console.WriteLine(""+nome);
        }
    }
}
