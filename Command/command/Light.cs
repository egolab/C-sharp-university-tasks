using System;

namespace command
{
    class Light: ISwitchableItem
    {
        private double dimness = 60;

        public void SwitchOn()
        {
            Console.WriteLine("Light is ON");
        }

        public void SwitchOff()
        {
            Console.WriteLine("Light is OFF");
        }

        public void Up()
        {
            dimness += 10;
            Console.WriteLine($"Dimness UP: Dimness is set to {dimness} %");
        }

        public void Down()
        {
            dimness -= 10;
            Console.WriteLine($"Dimness DOWN: Dimness is set to {dimness} %");
        }

        public void SetValue(double dimness)
        {
            this.dimness = dimness;
            Console.WriteLine($"Dimness SET: Dimness is set to {dimness} %");
        }
    }
}