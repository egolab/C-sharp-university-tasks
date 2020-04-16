using System;

namespace Observer
{
    class Program
    {
        static void Main(string[] args)
        {
            /*  
            * each observer can set customized temperature and pressure alert levels;
            * observer is notified each time the weather data changes and is being sent extra alerts based on own 
            * temperature and pressure alert levels
            */

            WeatherStation weatherStation = new WeatherStation();
            weatherStation.Add(new Observer(weatherStation, "Observer 1", -15, 30, 1000, 1050));
            weatherStation.Add(new Observer(weatherStation, "Observer 2", 0, 25, 1010, 1040));

            weatherStation.Notify();
        }
    }
}
