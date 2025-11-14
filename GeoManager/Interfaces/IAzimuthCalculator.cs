using GeographyManager.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeographyManager.Interfaces
{
    public interface IAzimuthCalculator
    {
        double CalculateAzimuth(GeoPoint p1, GeoPoint p2);
    }
}
