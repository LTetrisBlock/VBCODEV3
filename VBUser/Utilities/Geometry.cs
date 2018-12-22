using System;
using System.Collections.Generic;
using System.Text;

namespace VBUser.Utilities.Geometery
{
    public  class Geometry
    {

        public static  double CalculateDistanceBetweenTwoPoints(Point p1, Point p2)
        {
            double r = -1 ;

            r = Math.Sqrt((Math.Pow((p1.X + p2.X), 2) + Math.Pow((p1.Y + p2.Y), 2)));

            return r;
        }
    }


    public class Point
    {
        public Point (double x, double y)
        {
            X = x;
            Y = y;
        }

        /// <summary>
        /// Basic Contrsutor. 
        /// </summary>
        public Point()
        {
            X = 0;
            Y = 0;
        }

        public double X { get; set; }
        public double Y { get; set; }
    }

        
}
