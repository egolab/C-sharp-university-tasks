using System;
using System.Collections.Generic;
using System.Text;

namespace abstractFactory
{
    public class Shark : Animal
    {
        public Shark(string c, double w, int s)
        {
            color = c;
            weight = w;
            speed = s;
        }

        public override string ShowData()
        {
            return "Shark";
        }
        public override string ToString()
        {
            return "Lion\nColor: " + color + "\nWeight: " + weight + "\nSpeed: " + speed;
        }
    }
}
