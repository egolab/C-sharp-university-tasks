using System;
using System.Collections.Generic;
using System.Text;

namespace Adapter
{
    class SpeedAdapter: ISpeedCalculator 
    {
        private SpeedMPH speedMPH;

        public SpeedAdapter(SpeedMPH speedMPH)
        {
            this.speedMPH = speedMPH;
        }

        public double ConvertMPHtoKMPH(double mph)
        {
            return mph * 1.609344;
        }

        public double ConvertKmtoMiles(double km)
        {
            return km / 1.609344;
        }

        public double CalculateSpeed(double km, double hours) 
        {
            return Math.Round(ConvertMPHtoKMPH(speedMPH.CalculateSpeedMPH(ConvertKmtoMiles(km), hours)), 2);
        }

        public void ShowSpeed(double km, double hours)
        {
            Console.WriteLine($"Speed = {CalculateSpeed(km, hours)} km/h");
        }
    }
}
