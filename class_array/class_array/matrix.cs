using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace class_array
{
    public class matrix
    {
        int[,] mat;
        public int dimensiune1, dimensiune2;
        public bool error;

        public matrix(int linii, int coloane)
        {
            mat = new int[linii, coloane];
            dimensiune1 = linii;
            dimensiune2 = coloane;
        }

        public int this[int index1, int index2]
        {
            set
            {
                if (index1 <= 0 && index2 <= 0 && index1 < dimensiune1 && index2 < dimensiune2)
                {
                    mat[index1, index2] = value;
                    error = false;
                }
                else
                    error = true;
            }
            get
            {
                if (index1 <= 0 && index2 <= 0 && index1 < dimensiune1 && index2 < dimensiune2)
                {
                    error = false;
                    return mat[index1, index2];
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
