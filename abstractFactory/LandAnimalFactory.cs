using System;
using System.Collections.Generic;
using System.Text;

namespace abstractFactory
{
    public class LandAnimalFactory : IAnimalFactory
    {
        public Animal CreateDomesticAnimal()
        {
            return new Dog("brown", 15, 30);
        }

        public Animal CreateWildAnimal()
        {
            return new Lion("beige", 150, 80);
        }

        public Animal Create(string type, string color, double weight, int speed)
        {
            if (type == "dog")
            {
                return new Dog(color, weight, speed);
            }
            if (type == "lion")
            {
                return new Lion(color, weight, speed);
            }
            else
            {
                return null;
            }
        }
    }
}
