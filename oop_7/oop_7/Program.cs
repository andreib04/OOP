using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oop_7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Complex z1 = new ComplexD(2, 3);
        
            int k = 3;

            Console.WriteLine(z1.ridicare_la_putere(k));
        }
    }
}
