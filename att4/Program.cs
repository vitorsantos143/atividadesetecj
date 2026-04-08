using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace att4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            excel Media = new excel();
            Media.pedirn1();
            Media.pedirn2();
            Media.pedirn3();
            Media.calculo();
            Media.calculoMedia();
        }
    }
}
