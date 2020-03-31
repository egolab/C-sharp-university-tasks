using System;
using System.Collections.Generic;
using System.Text;

namespace FactoryMethod
{
    class CarFactory
    {
        public IVehicle CreateVehicle()
        {
            return new Car();
        }
    }
}
