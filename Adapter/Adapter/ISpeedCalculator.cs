using System;
using System.Collections.Generic;
using System.Text;

namespace Adapter
{
    interface ISpeedCalculator
    {
        double CalculateSpeed(double km, double hours);

        void ShowSpeed(double km, double hours);
    }
}