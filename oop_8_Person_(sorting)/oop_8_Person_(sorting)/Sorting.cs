using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oop_8_Person__sorting_
{
        public class SortByName : IComparer<Person>
        {
            public int Compare(Person p1, Person p2)
            {
                return string.Compare(p1.name, p2.name);
            }
        }

        public class SortByAge : IComparer<Person>
        {
            public int Compare(Person p1, Person p2)
            {
                if (p1.age < p2.age)
                    return -1;
                if (p1.age > p2.age)
                    return 1;
                return 0;
            }
        }
}
