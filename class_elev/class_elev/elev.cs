using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace class_elev
{
    public class elev
    {
        public string nume { get; }
        public string prenume { get; }
        public double mediaAritm { get; }

        public elev(string nume, string prenume, double mediaAritm)
        {
            this.nume = nume;
            this.prenume = prenume;    
            this.mediaAritm = mediaAritm;   
        }

        public override string ToString()
        {
            return nume + " " + prenume + " " + mediaAritm.ToString();
        }

    }
}
