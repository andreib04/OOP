using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace class_array
{
    public class Names
    {
        public int size;
        string[] names;

        public Names(int n)
        {
            size = n;
            names = new string[size];

            for (int i = 0; i < size; i++)
                names[i] = "N.A";
        }

        bool error;

        public string this[int index]
        {
            get
            {
                return (index >= 0 && index < size) ? names[index] : null;
            }
            set
            {
                if(index >= 0 && index < size)
                {
                    names[index] = value;
                }
            }
        }

        public int this[string nm]
        {
            get
            {
                int index = 0;
                while(index++ < size)
                {
                    if (string.Compare(names[index], nm) == 0)
                        return index;
                }
                return -1;
            }
        }
    }
}
