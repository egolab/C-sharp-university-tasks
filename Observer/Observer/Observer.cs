using System;
using System.Collections.Generic;
using System.Text;

namespace Observer
{
    class Observer
    {
        WeatherStation weatherStation = new WeatherStation();

        public int MinAlertTemperature { get; set; }
        public int MaxAlertTemperature { get; set; }
        public int MinAlertPressure { get; set; }
        public int MaxAlertPressure{ get; set; }
        public string ObserverName { get; set; }

        public Observer(WeatherStation weatherStation, string observerName, int minAlertTemp, int maxAlertTemp, int minAlertPressure, int maxAlertPressure)
        {
            this.weatherStation = weatherStation; 
            ObserverName = observerName;
            MinAlertTemperature = minAlertTemp;
            MaxAlertTemperature = maxAlertTemp;
            MinAlertPressure = minAlertPressure;
            MaxAlertPressure = maxAlertPressure;
        }

        public void Update()
        {
            Console.WriteLine($"\n*** {ObserverName} ***");
            ShowTemperature();
            ShowPressure();
            ShowRain();
        }

        public void ShowTemperature()
        {
            Console.Write($"Temperature: {weatherStation.Temperature} degrees");

            if (weatherStation.Temperature > MaxAlertTemperature)
                Console.WriteLine(" - Very HOT!");
            else if (weatherStation.Temperature < MinAlertTemperature)
                Console.WriteLine(" - Very COLD!");
            else
                Console.WriteLine();
        }

        public void ShowPressure()
        {
            Console.Write($"Pressure: {weatherStation.Pressure} hPa");

            if (weatherStation.Pressure > MaxAlertPressure)
                Console.WriteLine(" - Very HIGH!");
            else if (weatherStation.Pressure < MinAlertPressure)
                Console.WriteLine(" - Very LOW!");
            else
                Console.WriteLine();
        }

        public void ShowRain()
        {
            Console.WriteLine($"Rain: {(weatherStation.Rain ? "YES - take an umbrella with you!" : "NO")}");
        }
    }
}