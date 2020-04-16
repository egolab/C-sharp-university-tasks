using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace Observer
{
    class WeatherStation: IObservable
    {
        private List<Observer> observers = new List<Observer>();

        public int Temperature { get; set; }
        public int Pressure { get; set; }
        public bool Rain { get; set; }

        private Random random = new Random();

        private void SetNewWeatherData() // weather data is set to random values
        {
            Temperature = random.Next(-20, 30);
            Pressure = random.Next(980, 1050); 
            Rain = Convert.ToBoolean(random.Next(0, 2));
        }

        public void Add(Observer observer)
        {
            observers.Add(observer);
        }

        public void Remove(Observer observer)
        {
            observers.Remove(observer);
        }

        public void Notify()
        {
            for (int i = 0; i < random.Next(3, 10); i++) // there is random number of updates 
            {
                SetNewWeatherData();
                Thread.Sleep(random.Next(1000, 6000)); // time between updates is set to random value between 1 and 6 seconds
                Console.WriteLine($"Update no. {i + 1}");

                foreach (Observer observer in observers)
                    observer.Update();
                Console.WriteLine();
            }
        }
    }
}