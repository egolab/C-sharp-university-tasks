using System;
using System.Collections.Generic;
using System.Text;

namespace FactoryMethod
{
    class Car : IVehicle
    {
        public string ShowData()
        {
            return "Vehicle type: Car";
        }
    }
}
