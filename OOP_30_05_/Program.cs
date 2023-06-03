using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace OOP_30_05_
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Publisher publisher = new Publisher();
            SubscriberA sbA = new SubscriberA();
            SubscriberB sbB = new SubscriberB();

            publisher.eveniment += sbA.Ab;
            publisher.eveniment += sbB.Ab;

            publisher.DeclansareEveniment();

            publisher.eveniment -= sbA.Ab;

            publisher.DeclansareEveniment();

           //MyEvent e = new MyEvent();

            //e.activare += new MyEventHandlerDelegate(EventDemo.HandlerEv);

            //e.Fire();


            //EvenimentMultiCast ev = new EvenimentMultiCast();
            //A obA = new A(); B obB = new B();

            //ev.activare += new MyEventHandlerDelegate(EventDemo.HandlerEv);
            //ev.activare += new MyEventHandlerDelegate(obA.AHandler);
            //ev.activare += new MyEventHandlerDelegate(obB.BHandler);
            //ev.Fire();
            //Console.WriteLine();
            //ev.activare -= new MyEventHandlerDelegate(obA.AHandler);
            //ev.Fire();
        }

    }


}
