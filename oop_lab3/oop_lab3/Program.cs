using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oop_lab3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int linii = int.Parse(Console.ReadLine());
            Stars stars = new Stars(linii);

            Console.ForegroundColor = ConsoleColor.Red;
            stars.Afisare();
        }
        
        class Stars
        {
            int linii;
            public Stars(int linii)
            {
                this.linii = linii;
            }

            
            public void Afisare()
            {
                for(int i = 0; i <= linii; i++)
                {
                    
                    for(int j = 0; j < i; j++)
                    {
                        Console.Write("*" + " ");
                    }
                    Console.WriteLine();
                }
            }

            ~Stars()
            {
                Console.WriteLine("Stars");
            }
        }
        
        
            //Console.WriteLine("Dati lungimea: ");
            //double L = double.Parse(Console.ReadLine());
            //Console.WriteLine("Dati latimea: ");
            //double lat = double.Parse(Console.ReadLine());
            //Dreptunghi d = new Dreptunghi(L, lat);

            //d.Lungime = L;
            //d.Latime = lat;
            //Console.WriteLine("Aria = " + (d.Lungime * d.Latime));

        /*
        class Dreptunghi
        {
            
            public Dreptunghi(double lungime, double latime) //constructor cu 2 parametrii
            {
                Lungime = lungime;
                Latime = latime;
            }

            double lungime;
            public double Lungime //proprietate
            {
                get { return lungime; }
                set { if(value > 0) lungime = value; }
            }

            public double Latime //auto-proprietate
            {
                get; set;
            }
            
        }
        */

        //CALCULATOR 
        /*
        class Calculator
        {

            public double a;
            public double b;
            public Calculator(double a, double b)
            {
                this.a= a; 
                this.b = b;
            }

            public double Suma()
            {

                return a + b;
            }

            public double Scadere()
            {
                return a - b;
            }

            public double Inmultire()
            {
                return a*b;
            }

            public double Impartire()
            {
                return a / b;
            }
        }

        */

        //Prima aplicatie oop
        /*
        class Hello
        {
            public static int ID = 0;

            public Hello()
            {
                Console.WriteLine("Hello, World!");
                ID++;
            }

            ~Hello()
            {
                Console.WriteLine("bucovina");
            }

            static Hello()
            {
                Console.WriteLine("Static");
                ID++; 
            }


        }
        */

    }

}
