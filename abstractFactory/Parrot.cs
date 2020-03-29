using System;
using System.Collections.Generic;
using System.Text;

namespace abstractFactory
{

    public class Parrot : Animal
    {
        public Parrot(string c, double w, int s)
        {
            color = c;
            weight = w;
            speed = s;
        }

        public override string ShowData()
        {
            return "Parrot";
        }
        public override string ToString()
        {
            return "Parrot\nColor: " + color + "\nWeight: " + weight + "\nSpeed: " + speed;
        }
    }
}
