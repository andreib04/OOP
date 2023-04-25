using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oop_7
{
    public class ComplexD : Complex
    {
        public ComplexD(double real, double imaginar)
        {
            this.real = real;
            this.imaginar = imaginar;
        }

        public override string ridicare_la_putere(int k)
        {
            double rad = (double)Math.Sqrt(Math.Pow(this.real, 2) * Math.Pow(this.imaginar, 2));
            double phi = Math.Atan(this.imaginar / this.real);

            double radn = 1, phin = 1;
            for (int i = 0; i < k; i++)
            {
                radn *= rad;
            }
            phin = k * phi;

            string s = radn + " * (cos(" + phin + ") + i * sin(" + phin + "))";
            return s;
        }

        public void Distanta()
        {
            Console.Write("n = ");
            int j = 1, n = int.Parse(Console.ReadLine());

            double x, y, d = Double.MaxValue, dd;
            for(int i = 0; i < n; i++)
            {
                x = double.Parse(Console.ReadLine());
                y = double.Parse(Console.ReadLine());

                dd = Math.Sqrt(Math.Pow(this.real - x, 2) + Math.Pow(this.imaginar - y, 2));
                if(d > dd)
                {
                    j = i + 1;
                    d = dd;
                }
            }

            Console.WriteLine(j + " " + d);
        }
    }
}
