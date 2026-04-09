using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace att9
{
    internal class Program
    {
        static void Main(string[] args)
        {
            leitor boasvindas = new leitor();
            boasvindas.pedirNome();
            boasvindas.pedirIdade();
            boasvindas.boasVindas();
        }
    }
}
