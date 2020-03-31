using System;
using System.Collections.Generic;
using System.Text;

namespace FactoryMethod
{
    interface IVehicleFactory
    {
        IVehicle CreateVehicle();
    }
}
