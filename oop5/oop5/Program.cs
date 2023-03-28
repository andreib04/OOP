using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oop5
{
    internal class Program
    {
        static void Main(string[] args)
        {
                 
        }

        class Rational
        {
            private double numarator { get; set; }
            private double numitor { get; set; }

            public Rational(double numarator = 0, double numitor = 1)
            {
                if (numitor < 0)
                    this.numarator = -numarator;
                else
                    this.numarator = numarator;
                if (numitor == 0)
                    this.numitor = 1;
                else
                    this.numitor = Math.Abs(numitor);
            }

            public override string ToString()
            {
                StringBuilder sb = new StringBuilder();

                if (numitor == 1)
                    sb.AppendFormat($"{numarator}");
                else
                    if (numarator == 0)
                    sb.AppendFormat("0");
                else
                    sb.AppendFormat($"{numarator} / {numitor}");
                return sb.ToString();
            }

            public static Rational operator +(Rational a, Rational b)   // a = numarator; b = numitor
            {
                return new Rational(a.numarator * b.numitor + b.numarator * a.numitor, a.numitor * b.numitor);
            }

            public static Rational operator -(Rational a, Rational b)
            {
                return new Rational(a.numarator * b.numitor - b.numarator * a.numitor, a.numitor * b.numarator);
            }

            public static Rational operator *(Rational a, Rational b)
            {
                return new Rational(a.numarator * b.numarator, a.numitor * b.numitor);
            }

            public static Rational operator /(Rational a, Rational b)
            {
                if (b.numarator == 0)
                    throw new DivideByZeroException();
                return new Rational(a.numarator * b.numitor, a.numitor * b.numarator);
            }

            public static Rational operator ^(Rational a, int n)
            {
                return new Rational(Math.Pow(a.numarator, n), Math.Pow(a.numitor, n));
            }

            public static bool operator ==(Rational a, Rational b)
            {
                if (a.numarator * b.numitor == b.numarator * a.numitor)
                    return true;
                return false;
            }

            public static bool operator !=(Rational a, Rational b)
            {
                if (a == b)
                    return true;
                return false;
            }

            public static bool operator <(Rational a, Rational b)
            {
                if (a.numarator * b.numitor < b.numarator * a.numitor)
                    return true;
                return false;
            }

            public static bool operator >(Rational a, Rational b)
            {
                if (a > b)
                    return true;
                return false;
            }

            public static bool operator <=(Rational a, Rational b)
            {
                if (a <= b)
                    return true;
                return false;
            }

            public static bool operator >=(Rational a, Rational b)
            {
                if (a >= b)
                    return true;
                return false;
            }

            static int cmmdc(int a, int b)
            {
                if (b == 0)
                    return a;
                else
                    return cmmdc(b, a % b);
            }

        }

        class Complex
        {
            private double real { get; set; }
            private double imaginar { get; set; }

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

            public static Complex operator ^(Complex a, double n)
            {
                Complex c = new Complex(1, 0);
                for (int i = 1; i <= n; i++)
                {
                    c *= a;
                }
                return c;
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
}
