using System;

namespace Adapter
{
    class Program
    {
        static void Main(string[] args)
        {
            ISpeedCalculator target = new SpeedAdapter(new SpeedMPH());

            // we want to have a result in kmph but we use a method that returns mph
            target.ShowSpeed(100, 2);
            target.ShowSpeed(50, 3);
            target.ShowSpeed(350, 4);
            target.ShowSpeed(127, 3); 
        }
    }
}
