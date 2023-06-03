using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_30_05_
{
    public delegate void MyEventHandlerDelegate();
    public class MyEvent
    {
        //declarare eveniment
        public event MyEventHandlerDelegate activare;

        //metoda care genereaza
        public void Fire()
        {
            activare();
        }
    }

    public class EventDemo
    {
        public static void HandlerEv()
        {
            Console.WriteLine("Evenimentul s-a produs");
        }

    }
}
