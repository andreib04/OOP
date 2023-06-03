using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_30_05_
{
    public delegate void MyEventHandlerDelegate_();
    public class EvenimentMultiCast
    {
        public event MyEventHandlerDelegate activare;

        public void Fire()
        {
            if(activare != null) 
                activare();
        }
    }

    class A
    {
        public void AHandler()
        {
            Console.WriteLine("Eveniment tratat si de metoda AHandler");
        }
    }

    class B
    {
        public void BHandler()
        {
            Console.WriteLine("Eveniment tratat si de metoda BHandler");
        }
    }
}
