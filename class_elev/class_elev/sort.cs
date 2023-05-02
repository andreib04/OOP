using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace class_elev
{
    public class SortElevi : IComparer<elev>
    {
        public int Compare(elev e1, elev e2)
        {
            if (e1.mediaAritm > e2.mediaAritm)
                return -1;
            if (e1.mediaAritm < e2.mediaAritm)
                return 1;
            else
                return string.Compare(e1.nume + e1.prenume, e2.nume + e2.prenume);
        }
    }

   
}
