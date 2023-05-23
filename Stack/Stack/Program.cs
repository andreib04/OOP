using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stack
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Stiva<char> st = new Stiva<char>(5);

            for (char c = 'a'; c <= 'f'; c++)
            {
                st.myPush(c);
            }

            for (int i = 0; i < 7; i++)
            {
                char x = st.myPop();
                if (x != default)
                    Console.WriteLine($"Element scos din stiva {x}");
                else
                    Console.WriteLine("Stiva este goala");
            }

            st.myClear();

            Stiva<int> stiva = new Stiva<int>(5);
            for (int i = 0; i < 5; i++)
                stiva.myPush(i);

            for (int i = 0; i < 5; i++)
            {
                int x = stiva.myPop();
                if (x != default)
                    Console.WriteLine(x);
                else
                    Console.WriteLine("empty");
            }

            stiva.myClear();

            int a = 5, b = 6;
            Console.WriteLine($"before a = {a}, b = {b}");
            Swap(ref a, ref b);
            Console.WriteLine($"after a = {a}, b = {b}");


            char c = 'a', d = 'b' ;
            Console.WriteLine($"before a = {c}, b = {d}");
            Swap(ref c, ref d);
            Console.WriteLine($"after a = {c}, b = {d}");
        }

        static void Swap<T>(ref T first, ref T second)
        {
            T aux = first;
            first = second;
            second = aux;
            Console.Write("generic\n");
        }

        static void Swap(ref int first, ref int second)
        {
            int aux = first;
            first = second;
            second = aux;
            Console.Write("non-generic\n");
        }

    }
}
