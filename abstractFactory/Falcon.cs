using System;
using System.Collections.Generic;
using System.Text;

namespace abstractFactory
{
    public class Falcon : Animal
    {
        public Falcon(string c, double w, int s)
        {
            color = c;
            weight = w;
            speed = s;
        }
        public override string ShowData()
        {
            return "Falcon";
        }

        public override string ToString()
        {
            return "Falcon\nColor: " + color + "\nWeight: " + weight + "\nSpeed: " + speed;
        }
    }
}
