using System;
using System.Collections.Generic;
using System.Text;

namespace FactoryMethod
{
    class TrainFactory
    {
        public IVehicle CreateVehicle()
        {
            return new Train();
        }
    }
}
