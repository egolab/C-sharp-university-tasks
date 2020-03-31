using System;

namespace FactoryMethod
{
    class Program
    {
        static void Main(string[] args)
        {
            CarFactory carFactory = new CarFactory();
            TrainFactory trainFactory = new TrainFactory();

            IVehicle car = carFactory.CreateVehicle();
            Console.WriteLine(car.ShowData());
            Console.WriteLine();

            IVehicle train = trainFactory.CreateVehicle();
            Console.WriteLine(train.ShowData());
        }
    }
}