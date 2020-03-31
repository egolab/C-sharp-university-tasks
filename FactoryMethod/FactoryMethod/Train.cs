using System;
using System.Collections.Generic;
using System.Text;

namespace FactoryMethod
{
    class Train : IVehicle
    {
        public string ShowData()
        {
            return "Vehicle type: Train";
        }
    }
}
