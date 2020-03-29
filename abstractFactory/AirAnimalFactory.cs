using System;
using System.Collections.Generic;
using System.Text;

namespace abstractFactory
{
    public class AirAnimalFactory : IAnimalFactory
    {
        public Animal CreateDomesticAnimal()
        {
            return new Parrot("green", 5, 40);
        }

        public Animal CreateWildAnimal()
        {
            return new Falcon("brown", 20, 200);
        }

        public Animal Create(string type, string color, double weight, int speed)
        {
            if (type == "falcon")
            {
                return new Falcon(color, weight, speed);
            }
            if (type == "parrot")
            {
                return new Parrot(color, weight, speed);
            }
            else
            {
                return null;
            }
        }
    }
}
