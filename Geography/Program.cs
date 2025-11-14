using GeographyManager;
using GeographyManager.Services;
using System;

namespace Geography
{

    class Program
    {
        static void Main()
        {
            var geoManager = new GeoManager(
                new DistanceCalculator(),
                new AzimuthCalculator(),
                new UnitConverter()
            );

            geoManager.ProcessEverything();
        }
    }
}   
