using System;
using System.Collections.Generic;
using System.Text;

namespace command
{
    interface ISwitchableItem // receiver
    {
        void SwitchOn();

        void SwitchOff();

        void Up();

        void Down();

        void SetValue(double value);
    }
}