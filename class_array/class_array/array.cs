using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace class_array
{
    public class array
    {
        int[] v;
        public int dimensiune;
        public bool error;

        public array(int lungime)
        {
            v = new int[lungime];
            dimensiune = lungime;
        }

        public int this[int index]
        {
            set
            {
                if (index >= 0 && index < dimensiune)
                {
                    v[index] = value;
                    error = false;
                }
                else
                    error = true;
            }
            get
            {
                if(index >= 0 && index < dimensiune)
                {
                    error = false;
                    return v[index];
                }
                else
                {
                    error = true;
                    return -1;
                }
                
            }
        }
    }
}
