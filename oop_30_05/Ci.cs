using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oop_30_05
{
    public delegate void MyDelegate__(double r, ref double[] a, ref int i);
    public class Circle__
    {
        const float PI = 3.14159f;

        public static void Aria(double r, ref double[] a, ref int i)
        {
            a[++i] = PI * r * r;
        }

        public static void LungFrontiera(double r, ref double[] a, ref int i)
        {
            a[++i] = 2 * PI * r;
        }

        public static void Cercul(double r, ref double[] a, ref int i)
        {
            Console.WriteLine($"Cercul de raza r ={r} are: ");
            a[++i] = 0;
        }
    }
}
