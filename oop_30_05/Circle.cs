using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oop_30_05
{
    public delegate double MyDelegate(double a);

    public class Circle
    {
        const float PI = 3.14159f;

        public static double Aria(double r)
        {
            return (PI * r * r);
        }

        public static double LungFrontiera(double r)
        {
            return (2 * PI * r);
        }
    }
}
