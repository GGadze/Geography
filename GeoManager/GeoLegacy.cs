using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeographyManager
{

    
    public class GeoLegacy
    {

        public double d2r(double d)
        {
            return d * 0.017453292519943295;
        }

        
        public double CalcD(double[] p1, double[] p2)
        {
            double a = p1[0];
            double b = p1[1];
            double c = p2[0];
            double d = p2[1];

            double e = d2r(a);
            double f = d2r(c);
            double g = d2r(c - a);
            double h = d2r(d - b);

            double i = Math.Sin(g / 2) * Math.Sin(g / 2) + Math.Cos(e) * Math.Cos(f) * Math.Sin(h / 2) * Math.Sin(h / 2);
            double j = 2 * Math.Atan2(Math.Sqrt(i), Math.Sqrt(1 - i));
            double k = 6371 * j;

            return k;
        }

        
        public double GetAz(double[] p1, double[] p2)
        {
            double lat1 = d2r(p1[0]);
            double lat2 = d2r(p2[0]);
            double dl = d2r(p2[1] - p1[1]);

            double x = Math.Sin(dl) * Math.Cos(lat2);
            double y = Math.Cos(lat1) * Math.Sin(lat2) - Math.Sin(lat1) * Math.Cos(lat2) * Math.Cos(dl);
            double brng = Math.Atan2(x, y);

            return (brng * 57.29577951308232 + 360) % 360;
        }

        public double KmToMiles(double km)
        {
            return km * 0.621371;
        }

        public double MilesToKm(double miles)
        {
            return miles / 0.621371;
        }

        public double MToFeet(double m)
        {
            return m * 3.28084;
        }

        public double FeetToM(double feet)
        {
            return feet / 3.28084;
        }

        public double HectaresToAcres(double ha)
        {
            return ha * 2.47105;
        }

        public double AcresToHectares(double acres)
        {
            return acres / 2.47105;
        }

       
        public void PrintAllConversions()
        {
            Console.WriteLine("Конвертации:");
            Console.WriteLine($"10 км = {KmToMiles(10)} миль");
            Console.WriteLine($"100 м = {MToFeet(100)} футов");
            Console.WriteLine($"5 га = {HectaresToAcres(5)} акров");
        }
    }

   
    public class GeoManager
    {
        private GeoLegacy geo = new GeoLegacy();

        public void ProcessEverything()
        {
            double[] moscow = new double[] { 55.7558, 37.6173 };
            double[] spb = new double[] { 59.9343, 30.3351 };

            double dist = geo.CalcD(moscow, spb);
            double azimuth = geo.GetAz(moscow, spb);

            Console.WriteLine($"Расстояние: {dist} км");
            Console.WriteLine($"Азимут: {azimuth}°");

            geo.PrintAllConversions();
        }
    }
}
