using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oop_lab1
{
    internal class Program
    {

        class Person
        {
            int age;
            string name;
            public void SayHi()
            {
                Console.WriteLine("Hi");
            }
        }

        static void Main(string[] args)
        {
            Person p1 = new Person();
            p1.SayHi();

        }
        
    }


}
