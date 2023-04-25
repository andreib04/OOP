using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oop_8_Person__sorting_
{
    internal class Program
    {
        public static void print(List<Person> list)
        {
            foreach (object person in list) 
            {
                Console.WriteLine(person);
            }
        }

        static void Main(string[] args)
        {
            List<Person> persons = new List<Person>();
            persons.Add(new Person("Andrei", 28));
            persons.Add(new Person("Raul", 35));
            persons.Add(new Person("Ciprian", 18));
            persons.Add(new Person("Darius", 45));
            persons.Add(new Person("Adrian", 29));
            persons.Add(new Person("George", 24));
            persons.Add(new Person("Sebastian", 66));
            persons.Add(new Person("Denis", 20));
            persons.Add(new Person("Ioan", 51));

            persons.Sort(new SortByName());
            Console.WriteLine("\n\nSorted by name: \n");
            print(persons);

            persons.Sort(new SortByAge());
            Console.WriteLine("\n\nSorted by age: \n");
            print(persons);


        }

    }
}
