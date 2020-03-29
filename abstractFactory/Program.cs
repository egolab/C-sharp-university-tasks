using System.Collections.Generic;
using System;

namespace abstractFactory
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Animal> animals = new List<Animal>();
            WaterAnimalFactory waterAnimalFactory = new WaterAnimalFactory();
            LandAnimalFactory landAnimalFactory = new LandAnimalFactory();
            AirAnimalFactory airAnimalFactory = new AirAnimalFactory();

            animals.Add(waterAnimalFactory.CreateDomesticAnimal());
            animals.Add(waterAnimalFactory.CreateWildAnimal());
            animals.Add(waterAnimalFactory.Create("aquarium fish", "red", 0.05, 2));
            animals.Add(waterAnimalFactory.Create("dolphin", "blue", 100, 60));

            animals.Add(landAnimalFactory.CreateDomesticAnimal());
            animals.Add(landAnimalFactory.CreateWildAnimal());
            animals.Add(landAnimalFactory.Create("dog", "black", 17, 45));
            animals.Add(landAnimalFactory.Create("lion", "brown", 190, 80));

            animals.Add(airAnimalFactory.CreateDomesticAnimal());
            animals.Add(airAnimalFactory.CreateWildAnimal());

            foreach (Animal v in animals)
            {
                Console.WriteLine(v + "\n");
            }
        }
    }
}
