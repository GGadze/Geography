using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeographyManager.Interfaces
{
    public interface IUnitConverter
    {
        double KmToMiles(double km);
        double MilesToKm(double miles);
        double MToFeet(double meters);
        double FeetToM(double feet);
        double HectaresToAcres(double hectares);
        double AcresToHectares(double acres);
    }
}
