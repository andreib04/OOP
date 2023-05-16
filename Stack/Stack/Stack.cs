using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stack
{
    public class Stiva<T>
    {
        private T[] elements;
        private int level;

        public Stiva(int max) 
        {
            elements = new T[max];
            level = -1;
        }

        public void myPush(T data)
        {
            if(level < elements.Count() - 1)
            {
                elements[level++] = data;
                Console.WriteLine($"Element adaugat in stiva: {data}");
            }
            else
            {
                Console.WriteLine("Stiva este plina");
            }
        }

        public T myPop()
        {
            if (level >= 0)
                return elements[level--];
            return default;
        }

        public void myClear()
        {
            level = -1;
            elements = new T[0];
            Console.WriteLine("Eliberare memorie");
        }

        
    }
}
