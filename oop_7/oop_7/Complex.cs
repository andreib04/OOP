using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oop_7
{
    public class Complex
    {
        protected double real, imaginar;

        public Complex(double p_real = 0, double p_imaginar = 0)
        {
            this.real = p_real;
            this.imaginar = p_imaginar;
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            if (imaginar > 0)
                sb.AppendFormat("{0:0.00} + {1:0.00}i", real, imaginar);
            else
                if (imaginar < 0)
                sb.AppendFormat("{0:0.00} + {1:0.00}i", real, Math.Abs(imaginar));
            else
                sb.AppendFormat("{0:0.00}", real);

            return sb.ToString();
        }

        public static Complex operator +(Complex a, Complex b)
        {
            Complex c = new Complex();
            c.real = a.real + b.real;
            c.imaginar = a.imaginar + b.imaginar;
            return c;
        }

        public static Complex operator -(Complex a, Complex b)
        {
            Complex c = new Complex();
            c.real = a.real - b.real;
            c.imaginar = a.imaginar - b.imaginar;
            return c;
        }

        public static Complex operator *(Complex a, Complex b)
        {
            Complex c = new Complex();
            c.real = (a.real * b.real) - (a.imaginar * b.imaginar);
            c.imaginar = (a.real * b.imaginar) + (a.imaginar + b.real);
            return c;
        }

        //public static Complex operator ^(Complex a, double n)
        //{
        //    Complex c = new Complex(1, 0);
        //    for (int i = 1; i <= n; i++)
        //    {
        //        c *= a;
        //    }
        //    return c;
        //}

        public virtual string ridicare_la_putere(int k)
        {
            Complex c = new Complex();
            for (int i = 1; i < k; i++)
                c = c * this;
            return c.ToString();
        }

        public double Teta(Complex a, Complex b)
        {
            double teta = Math.Atan(b.imaginar / a.real);
            return (double)teta;
        }

        public double R(Complex a, Complex b)
        {
            double R = Math.Sqrt((a.real * a.real) + (b.imaginar * b.imaginar));
            return (double)R;
        }

        public double Trigonometric(Complex a, Complex b)
        {
            double r = R(a, b);
            double teta = Teta(a, b);

            double Trigonometric = r * (Math.Cos(teta) + Math.Sin(teta));
            return (double)Trigonometric;
        }

    }
}
