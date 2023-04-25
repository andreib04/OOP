using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oop_8_Person__sorting_
{
    public class Person
    {
        public string name { get; }
        public int age { get; }

        public Person(string name, int age) 
        { 
            this.name = name;
            this.age = age;
        }

        public override string ToString()
        {
            return name + " " + age.ToString() + " years ";
        }
    }
}
