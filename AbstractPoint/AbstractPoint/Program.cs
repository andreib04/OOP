using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.ConstrainedExecution;
using System.Text;
using System.Threading.Tasks;

namespace AbstractPoint
{
    internal class Program
    { 
        public static Point PromptPoint(string prompt)
        {
            double x, y;
            AbstractPoint.PointRepresentation mod = AbstractPoint.PointRepresentation.Rectangular;
            Console.WriteLine(prompt);
            x = double.Parse(Console.ReadLine());
            y = double.Parse(Console.ReadLine());
            return new Point(mod, x, y);
        }

        static void Main(string[] args)
        {
            AbstractPoint p1, p2, p3;
            double p1p2Dist, p2p3Dist, p3p1Dist;

            p1 = PromptPoint("enter first point");
            p2 = PromptPoint("enter second point");
            p3 = PromptPoint("enter third point");

            p1.Rotate(Math.PI);
            p2.Move(1.0, 2.0);
            
            p1p2Dist = Math.Sqrt((p1.X - p2.X) * (p1.X-  p2.X) + (p1.Y - p2.Y) * (p1.Y - p2.Y));
            p2p3Dist = Math.Sqrt((p2.X - p3.X) * (p2.X - p3.X) + (p2.Y - p3.Y) * (p2.Y - p3.Y));
            p3p1Dist = Math.Sqrt((p3.X - p1.X) * (p3.X - p1.X) + (p3.Y - p1.Y) * (p3.Y - p1.Y));

            double perimeter = p1p2Dist + p2p3Dist + p3p1Dist;

            Console.WriteLine($"Triunghi: {p1} {p2} {p3} Perimetru: {perimeter}");
        }
    }
}
