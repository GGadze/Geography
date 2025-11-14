using GeographyManager.Interfaces;
using GeographyManager.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeographyManager.Services
{
    public class DistanceCalculator : ICoordinateConverter, IDistanceCalculator
    {
        public double DegreesToRadians(double degrees) => degrees * Math.PI / 180.0;
        public double RadiansToDegrees(double radians) => radians * 180.0 / Math.PI;

        public double CalculateDistance(GeoPoint p1, GeoPoint p2)
        {
            double lat1 = DegreesToRadians(p1.Latitude);
            double lat2 = DegreesToRadians(p2.Latitude);
            double deltaLat = DegreesToRadians(p2.Latitude - p1.Latitude);
            double deltaLon = DegreesToRadians(p2.Longitude - p1.Longitude);

            double a = Math.Sin(deltaLat / 2) * Math.Sin(deltaLat / 2) +
                       Math.Cos(lat1) * Math.Cos(lat2) *
                       Math.Sin(deltaLon / 2) * Math.Sin(deltaLon / 2);

            double c = 2 * Math.Atan2(Math.Sqrt(a), Math.Sqrt(1 - a));

            return 6371 * c;
        }
    }
}
