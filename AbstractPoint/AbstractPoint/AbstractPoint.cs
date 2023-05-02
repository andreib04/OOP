using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractPoint
{
    abstract public class AbstractPoint
    {
        public enum PointRepresentation { Polar, Rectangular }

        public abstract double X { get; set; }
        public abstract double Y { get; set; }

        public abstract double R { get; set; }
        public abstract double A { get; set; }


        public void Move(double dx, double dy)
        {
            X += dx;
            Y += dy;
        }

        public void Rotate(double angle)
        {
            A += angle; 
        }

        public override string ToString()
        {
            return "(" + string.Format("{0:0.00}", X) + ", " + string.Format("{0:0.00}", Y) + ")" + " " + 
                "[r: " + string.Format("{0:0.00}", R) + " ,a:" + string.Format("{0:0.00}", A) + "] ";
        }

        protected static double RadiusGivenXy(double x, double y)
        {
            return Math.Sqrt(x * x + y * y);
        }

        protected static double AngleGivenXy(double x, double y)
        {
            return Math.Atan2(y, x);
        }

        protected static double XGivenRadiusAngle(double r, double a)
        {
            return r * Math.Cos(a);
        }

        protected static double YGivenRadiusAngle(double r, double a)
        {
            return r * Math.Sin(a);
        }
    }
}
