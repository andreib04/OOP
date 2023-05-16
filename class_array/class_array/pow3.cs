using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace class_array
{
    public class pow3
    {
        public float this[float index]
        {
            get
            {
                if (index >= 0)
                    return (float)Math.Pow(3, index);
                else
                    return -1;
            }
        }
    }
}
