using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_30_05_
{
    public delegate void iteratie(int x);
    public class Publisher
    {
        public event iteratie eveniment;

        public void DeclansareEveniment()
        {
            for (int i = 0; i < 20;i+=2)
            {
                if (eveniment != null)
                    eveniment(i);
            }
        }
    }

    class SubscriberA
    {
        public void Ab(int x)
        {
            Console.WriteLine($"SubscriberA - iteratie: {x}");
        }
    }
    class SubscriberB
    {
        public void Ab(int x)
        {
            Console.WriteLine($"SubscriberB - iteratie: {x}");
        }
    }
}
