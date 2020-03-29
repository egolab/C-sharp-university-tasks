using System;
using System.Collections.Generic;
using System.Text;

namespace abstractFactory
{
    public class Lion : Animal
    {
        public Lion(string c, double w, int s)
        {
            color = c;
            weight = w;
            speed = s;
        }

        public override string ShowData()
        {
            return "Lion";
        }

        public override string ToString()
        {
            return "Lion\nColor: " + color + "\nWeight: " + weight + "\nSpeed: " + speed;
        }
    }
}
