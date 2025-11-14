using GeographyManager.Interfaces;
using GeographyManager.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeographyManager
{
    public class GeoManager
    {
        private readonly IDistanceCalculator _distanceCalculator;
        private readonly IAzimuthCalculator _azimuthCalculator;
        private readonly IUnitConverter _unitConverter;

        public GeoManager(
            IDistanceCalculator distanceCalculator,
            IAzimuthCalculator azimuthCalculator,
            IUnitConverter unitConverter)
        {
            _distanceCalculator = distanceCalculator;
            _azimuthCalculator = azimuthCalculator;
            _unitConverter = unitConverter;
        }

        public void ProcessEverything()
        {
            GeoPoint moscow = new GeoPoint(55.7558, 37.6173);
            GeoPoint spb = new GeoPoint(59.9343, 30.3351);

            double distance = _distanceCalculator.CalculateDistance(moscow, spb);
            double azimuth = _azimuthCalculator.CalculateAzimuth(moscow, spb);

            Console.WriteLine($"Расстояние: {distance:F2} км");
            Console.WriteLine($"Азимут: {azimuth:F2}°");
            Console.WriteLine();

            Console.WriteLine("Конвертации:");
            Console.WriteLine($"10 км = {_unitConverter.KmToMiles(10):F2} миль");
            Console.WriteLine($"100 м = {_unitConverter.MToFeet(100):F2} футов");
            Console.WriteLine($"5 га = {_unitConverter.HectaresToAcres(5):F2} акров");
        }
    }
}
