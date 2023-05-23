using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Runtime.Remoting.Messaging;
using System.Security.AccessControl;
using System.Text;
using System.Threading.Tasks;

namespace oop_23_05
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Cerc c = new Cerc(3);
            Console.WriteLine("Afiseaza informatii despre {0}", c.denumire);
            IterDemo.DisplayInfo(c);

            Patrat p = new Patrat(3);
            Console.WriteLine("Afiseaza informatii despre {0}", p.denumire);
            IterDemo.DisplayInfo(p);

            Cub cub = new Cub(3);
            Console.WriteLine("Afiseaza informatii despre {0}", cub.Denumire);
            IterDemo.DisplayInfo(cub);
        }

        public interface IForma
        {
            string denumire { get; }
        }

        public interface IForma_
        {
            string denumire { get; }
        }

        public interface IForma2D : IForma
        {
            double Aria();
            double LungFrontiera();
        }

        public interface IForma3D : IForma, IForma_
        {
            double Volum();
        }

        public class Cerc : IForma2D
        {
            public double raza;
            private const float PI = 3.14159f;
            string s = "cerc";

            public Cerc(double r)
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

            public string denumire { get { return s; } }
        }

        public class Patrat : IForma2D
        {
            public double l;
            string s = "patrat";

            public Patrat(double latura)
            {
                l = latura;
            }

            public double Aria()
            {
                return (l * l);
            }

            public double LungFrontiera()
            {
                return (4 * l);
            }

            public string denumire { get { return s; } }
        }

        public class Cub : IForma3D
        {
            public double latura;
            string s = "cub";

            public Cub(double l)
            {
                latura = l;
            }

           public double Volum()
           {
                return (latura * latura * latura);
           }

           public string denumire { get { return s; } }

           public string Denumire
           {
                get
                {
                    Cub c = new Cub(3);
                    IForma f = c;
                    return f.denumire;
                }
           }
        }

        public class IterDemo
        {
            public static void DisplayInfo(IForma2D f)
            {
                Console.WriteLine("aria={0:#.##} \t " +
                                    "lungimea frontierei = {1:#.##}", f.Aria(), f.LungFrontiera() + "\n");
            }

            public static void DisplayInfo(IForma3D f)
            {
                Console.WriteLine("volumul={0:#.##}", f.Volum() + "\n");
            }
        }
    }
}
