using GeographyManager.Interfaces;
using GeographyManager.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeographyManager.Services
{
    public class AzimuthCalculator : ICoordinateConverter, IAzimuthCalculator
    {
        public double DegreesToRadians(double degrees) => degrees * Math.PI / 180.0;
        public double RadiansToDegrees(double radians) => radians * 180.0 / Math.PI;

        public double CalculateAzimuth(GeoPoint p1, GeoPoint p2)
        {
            double lat1 = DegreesToRadians(p1.Latitude);
            double lat2 = DegreesToRadians(p2.Latitude);
            double deltaLon = DegreesToRadians(p2.Longitude - p1.Longitude);

            double x = Math.Sin(deltaLon) * Math.Cos(lat2);
            double y = Math.Cos(lat1) * Math.Sin(lat2) -
                       Math.Sin(lat1) * Math.Cos(lat2) * Math.Cos(deltaLon);

            double bearing = Math.Atan2(x, y);
            return (RadiansToDegrees(bearing) + 360) % 360;
        }
    }
}
