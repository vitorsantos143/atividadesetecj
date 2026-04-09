using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace att4
{
    internal class excel
    {
        int n1;
        int n2;
        int n3;
        int media;
        public void pedirn1()
        {
            Console.WriteLine("Digite a primeira nota");
            n1 = int.Parse(Console.ReadLine());
        }
        public void pedirn2()
        {
            Console.WriteLine("Digite a segunda nota");
            n2 = int.Parse(Console.ReadLine());
        }
        public void pedirn3()
        {
            Console.WriteLine("Digite a terceira nota");
            n3 = int.Parse(Console.ReadLine());
        }

        public void calculo()
        {
            media = (n1 + n2 + n3) / 3;
        }
        public void calculoMedia()
        {
            if (media >= 7)
            {
                Console.WriteLine("Notas {0}, {1}, {2}, Média: Aprovado! {3}", n1, n2, n3, media);
            }
            else
            {
                Console.WriteLine("Notas {0}, {1}, {2}, Média: Reprovado! {3}", n1, n2, n3, media);
            }
        }
    }
}
