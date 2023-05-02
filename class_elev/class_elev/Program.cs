using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace class_elev
{
    internal class Program
    {
        static void Main(string[] args)
        {
            TextReader load = new StreamReader(@"..\..\catalog.txt");
            string buffer;
    
            List<string> elevi = new List<string>();
            elev elev;
            while ((buffer = load.ReadLine()) != null)
            {
                string[] local = buffer.Split(' ');
                string nume = local[0];
                string prenume = local[1];

                double mediaAritm = 0;
                int k = 0;
                for (int i = 0; i < Convert.ToInt32(local[2]); i++)
                {
                    mediaAritm += Convert.ToDouble(local[3 + i]);
                    k++;
                }
                mediaAritm = mediaAritm / Convert.ToInt32(local[2]);


                elev = new elev(nume, prenume, mediaAritm);

               elevi.Add(elev.ToString());
            }
            load.Close();

            elevi.Sort(new SortElevi());
            

            using (StreamWriter sw = new StreamWriter("output.txt"))
            {
               foreach(object o in elevi)
               {
                    sw.WriteLine(o.ToString());
               }
            }
           

        }
    }
}
