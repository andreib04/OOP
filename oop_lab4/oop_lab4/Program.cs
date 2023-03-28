using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oop_lab4
{
    internal class Program
    {
        
        
        static void Main(string[] args)
        {
            
        }

        class Time
        {
            private int ore;
            private int minute;
            private int secunde;
            private int sutimi;

            public Time(int ore, int minute, int secunde = 0, int sutimi = 0)
            {
                this.ore = ore;
                this.minute = minute;
                this.secunde = secunde;
                this.sutimi = sutimi;
            }

            public Time(string time)
            {
                string[] tokens = time.Split(':');
                this.ore = int.Parse(tokens[0]);
                this.minute = int.Parse(tokens[1]);
                this.secunde = int.Parse(tokens[2]);
                this.sutimi = int.Parse(tokens[3]);
            }

            public override string ToString()
            {
                StringBuilder sb = new StringBuilder();
                sb.AppendFormat(ore + " " + minute + " " + secunde + " " + sutimi);
                return sb.ToString();
            }

            public static bool operator > (Time t1, Time t2)
            {
                if(t1.ore > t2.ore)
                {
                    return true;
                }
                else if(t1.ore == t2.ore)
                {
                    if (t1.minute > t2.minute)
                    {
                        return true;
                    }
                    else if (t1.minute == t2.minute)
                    {
                        if (t1.secunde > t2.secunde)
                        {
                            return true;
                        }
                        else if (t1.secunde == t2.secunde)
                        {
                            if (t1.sutimi > t2.sutimi)
                            {
                                return true;
                            }
                            else
                            {
                                return false;
                            }
                        }
                        else
                        {
                            return false;
                        }
                    }
                    else
                    {
                        return false;
                    }
                }
                else
                {
                    return false;
                }
            }

            public static bool operator < (Time t1, Time t2)
            {
                if (t1.ore < t2.ore)
                {
                    return true;
                }
                else if (t1.ore == t2.ore)
                {
                    if (t1.minute < t2.minute)
                    {
                        return true;
                    }
                    else if (t1.minute == t2.minute)
                    {
                        if (t1.secunde < t2.secunde)
                        {
                            return true;
                        }
                        else if (t1.secunde == t2.secunde)
                        {
                            if (t1.sutimi < t2.sutimi)
                            {
                                return true;
                            }
                            else
                            {
                                return false;
                            }
                        }
                        else
                        {
                            return false;
                        }
                    }
                    else
                    {
                        return false;
                    }
                }
                else
                {
                    return false;
                }
            }

            public static bool operator ==(Time t1, Time t2)
            {
                if ((t1.ore == t2.ore) && (t1.minute == t2.minute) && (t1.secunde == t2.secunde) && (t1.sutimi == t2.sutimi))
                    return true;
                return false;
            }

            public static bool operator !=(Time t1, Time t2)
            {
                if (t1 == t2)
                    return false;
                return true;
            }

            public static bool operator <=(Time t1, Time t2)
            {
                if (t1 < t2 || t1 == t2)
                    return true;
                return false;
            }

            public static bool operator >=(Time t1, Time t2)
            {
                if (t1 > t2 || t1 == t2)
                    return true;
                return false;
            }

            public static Time operator +(Time t1, Time t2)
            {
                Time t = new Time(0, 0, 0, 0);
                int k;
                t.sutimi = (t1.sutimi + t2.sutimi) % 100;
                k = (t1.sutimi + t2.sutimi) / 100;

                t.secunde = (t1.secunde + t2.secunde) % 60;
                k = (t1.secunde + t2.secunde) / 60;

                t.minute = (t1.minute + t2.minute) % 60;
                k = (t1.minute + t2.minute) / 60;

                t.ore = t1.ore + t2.ore + k;
                return t;
            }

            public static Time operator -(Time t1, Time t2)
            {
                Time t = new Time(0, 0, 0, 0);
                if(t1.sutimi < t2.sutimi)
                {
                    t1.sutimi = 100;
                    t2.sutimi--;
                }
                return t;
            }

        }

        class Date
        {
            private int zi;
            private int luna;
            private int an;

            public Date(int zi, int luna, int an)
            {
                this.zi = zi;
                this.luna = luna;
                this.an = an;
            }

            public Date(string ZiLunaAn)
            {
                string[] tokens = ZiLunaAn.Split('.');
                this.zi = int.Parse(tokens[0]);
                this.an = int.Parse(tokens[1]);
                this.luna = int.Parse(tokens[2]);
            }

            public override string ToString()
            {
                StringBuilder sb = new StringBuilder();
                sb.AppendFormat(zi + " " + luna + " " + an);
                return sb.ToString();
            }

            public static bool operator > (Date d1, Date d2)
            {
                if (d1.an > d2.an)
                {
                    return true;
                }
                else if (d1.an == d2.an)
                {
                    if (d1.luna > d2.luna)
                    {
                        return true;
                    }
                    else if (d1.luna == d2.luna)
                    {
                        if(d1.zi > d2.zi)
                        {
                            return true;
                        }
                        else
                        {
                            return false;
                        }
                    }
                    else
                    {
                        return false;
                    }

                }
                else
                {
                    return false;
                }
            }

            public static bool operator < (Date d1, Date d2)
            {
                if(d1.an < d2.an)
                {
                    return true;
                }
                else if(d1.an == d2.an)
                {
                    if(d1.luna < d2.luna)
                    {
                        return true;
                    }
                    else if(d1.luna == d2.luna)
                    {
                        if(d1.zi < d2.zi)
                        {
                            return true;
                        }
                        else
                        {
                            return false;
                        }
                    }
                    else
                    {
                        return false;
                    }
                }
                else
                {
                    return false;
                }
            }

            public static bool operator == (Date d1, Date d2)
            {
                if ((d1.an == d2.an) && (d1.luna == d2.luna) && (d1.zi == d1.an))
                    return true;
                return false;
            }

            public static bool operator != (Date d1, Date d2)
            {
                if (d1 == d2)
                    return false;
                return true;
            }

            public static bool operator <= (Date d1, Date d2)
            {
                if (d1 < d2 || d1 == d2)
                    return true;
                return false;
            }

            public static bool operator >= (Date d1, Date d2)
            {
                if (d1 > d2 || d1 == d2)
                    return true;
                return false;
            }

            public int Zile(Date d)
            {
                //DateTime d1 = new DateTime(this.zi, this.luna, this.an);
                //DateTime d2 = new DateTime(other.zi, other.luna, other.an);
                //TimeSpan diferenta = d2 - d1;
                //return (int)diferenta.TotalDays;

                int zile = 0;
                for (int i = 1; i < d.an; i++)
                    zile += (DateTime.IsLeapYear(i)) ? 366 : 355;
                for (int i = 1; i < d.luna; i++)
                    zile += (DateTime.DaysInMonth(d.an, i));
                zile += d.zi;
                return zile;
            }

        }

    }
}
