using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeographyManager.Interfaces
{
    public interface ICoordinateConverter
    {
        double DegreesToRadians(double degrees);
        double RadiansToDegrees(double radians);
    }
}
