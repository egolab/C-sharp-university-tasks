using System;
using System.Collections.Generic;
using System.Text;

namespace abstractFactory
{
    public class Dog : Animal
    {
        public Dog(string c, double w, int s)
        {
            color = c;
            weight = w;
            speed = s;
        }

        public override string ShowData()
        {
            return "Dog";
        }

        public override string ToString()
        {
            return "Dog\nColor: " + color + "\nWeight: " + weight + "\nSpeed: " + speed;
        }
    }
}
