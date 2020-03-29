using System;
using System.Collections.Generic;
using System.Text;

namespace abstractFactory
{
    public class AquariumFish : Animal
    {
        public AquariumFish(string c, double w, int s)
        {
            color = c;
            weight = w;
            speed = s;
        }

        public override string ShowData()
        {
            return "Aquarium fish";
        }

        public override string ToString()
        {
            return "Aquarium Fish\nColor: " + color + "\nWeight: " + weight + "\nSpeed: " + speed;
        }
    }
}
