using System;
using System.Collections.Generic;
using System.Text;
using VBUser.Utilities.Geometery;

namespace VBUser
{
    public class UserLocation
    {
        double _layer = 0;
        Point point;
        double _y = 0;

        /// <summary>
        /// Constructor that sets, 
        /// </summary>
        /// <param name="x"></param>
        /// <param name="y"></param>
        public UserLocation(double x, double y)
        {
            point = new Point(x, y);
        }

        public Point GetPoint()
        {
            return point;
        }

        /// <summary>
        /// Get distance between two points
        /// </summary>
        /// <param name="userLocation"></param>
        /// <returns></returns>
        public double GetDistanceBetweenUser(UserLocation userLocation)
        {
            return Geometry.CalculateDistanceBetweenTwoPoints(point, userLocation.GetPoint());
        }    
    }
}
