using System;
using System.Collections.Generic;
using System.Text;

namespace Adapter
{
    class SpeedMPH // adaptee - miles per hour
    {
        public double CalculateSpeedMPH(double miles, double hours)
        {
            return miles / hours;
        }
    }
}
