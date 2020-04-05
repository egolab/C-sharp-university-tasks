using System;
using System.Collections.Generic;
using System.Text;

namespace Decorator
{
    interface ICoffee
    {
        double Cost();

        int Calories();

        string ShowInfo();
    }
}
