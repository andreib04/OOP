using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oop_30_05
{
    internal class Program
    {
        //delegare care apeleaza metode statice    
        // - || = metode non-statice
        static void Main(string[] args)
        {
            double raza = 3;
            MyDelegate del = new MyDelegate(Circle.Aria);
            Console.WriteLine($"Aria {del(raza)}");
            del = new MyDelegate(Circle.LungFrontiera);
            Console.WriteLine($"Lungimea frontierei {del(raza)} \n");


            Circle_ c = new Circle_(3);
            MyDelegate_ d = new MyDelegate_(c.Aria);
            Console.WriteLine($"Aria {d()}");
            d = new MyDelegate_(c.LungFrontiera);
            Console.WriteLine($"Lungimea Frontierei {d()} \n");


            double raza_ = 3;
            double[] rez = new double[3];
            int i = -1;
            MyDelegate__ dele = new MyDelegate__(Circle__.Cercul);
            dele += new MyDelegate__(Circle__.Aria);
            dele += new MyDelegate__(Circle__.LungFrontiera);

            dele(raza_, ref rez, ref i);

            Console.WriteLine($"aria {rez[1]} \n " +
                            $" lung frontiera {rez[2]}");


        }

    }
}
