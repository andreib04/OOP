using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractPoint
{
    public class Point : AbstractPoint
    {
        double Radius, Angle;

        public override double R 
        {
            get
            {
                return Radius;
            }
            set
            {
                Radius = value;
            }
        }

        public override double A 
        {
            get
            {
                return Angle;
            }
            set
            {
                Angle = value;
            }
        }

        public override double X 
        {
            get { return XGivenRadiusAngle(Radius, Angle); }
            set
            {
                double yB = YGivenRadiusAngle(Radius, Angle);
                Angle = AngleGivenXy(value, yB);
                Radius = RadiusGivenXy(value, yB);
            }
        }
        
        public override double Y 
        {
            get { return YGivenRadiusAngle(Radius, Angle); }
            set
            {
                double xB = XGivenRadiusAngle(Radius, Angle);
                Angle = AngleGivenXy(value, xB);
                Radius = RadiusGivenXy(value, xB);
            }
        }


        public Point(PointRepresentation p, double x, double y)
        {
            if (p == PointRepresentation.Polar)
            {
                Radius = x;
                Angle = y;
            }
            else if(p == PointRepresentation.Rectangular)
            {
                Radius = RadiusGivenXy(x, y);
                Angle = AngleGivenXy(x,y);
            }
            else
            {
                throw new Exception("nu s intampla");
            }
            
        }
    }
}
