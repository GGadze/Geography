using GeographyManager.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeographyManager.Services
{
    public class UnitConverter : IUnitConverter
    {
        public double KmToMiles(double km) => km * 0.621371;
        public double MilesToKm(double miles) => miles / 0.621371;
        public double MToFeet(double meters) => meters * 3.28084;
        public double FeetToM(double feet) => feet / 3.28084;
        public double HectaresToAcres(double hectares) => hectares * 2.47105;
        public double AcresToHectares(double acres) => acres / 2.47105;
    }

}
