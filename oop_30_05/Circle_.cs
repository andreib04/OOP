using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oop_30_05
{
    public delegate double MyDelegate_();
    public class Circle_
    {
        public double raza;
        private const float PI = 3.14159f;

        public Circle_(double r)
        {
            raza = r;
        }

        public double Aria()
        {
            return (PI * raza * raza);
        }

        public double LungFrontiera()
        {
            return (2 * PI * raza);
        }


    }
}
