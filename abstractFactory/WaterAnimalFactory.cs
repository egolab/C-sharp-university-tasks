using System;
using System.Collections.Generic;
using System.Text;

namespace abstractFactory
{
    public class WaterAnimalFactory : IAnimalFactory
    {
        public Animal CreateDomesticAnimal()
        {
            return new AquariumFish("orange", 0.1, 3);
        }

        public Animal CreateWildAnimal()
        {
            return new Shark("gray", 0, 50);
        }

        public Animal Create(string type, string color, double weight, int speed)
        {
            if (type == "shark")
            {
                return new Shark(color, weight, speed);
            }
            if (type == "aquarium fish")
            {
                return new AquariumFish(color, weight, speed);
            }
            else
            {
                return null;
            }
        }
    }
}
