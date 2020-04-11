using System;

namespace command
{
    class AirConditioning: ISwitchableItem
    {
        double temperature = 18;

        public void SwitchOn()
        {
            Console.WriteLine("Air Conditioner is ON");
        }

        public void SwitchOff()
        {
            Console.WriteLine("Air conditioner is OFF");
        }

        public void Up()
        {
            temperature += 2;
            Console.WriteLine($"Temperature UP: Temperature is set to {temperature} degrees");
        }

        public void Down()
        {
            temperature -= 2;
            Console.WriteLine($"Temperature UP: Temperature is set to {temperature} degrees");
        }

        public void SetValue(double temperature)
        {
            this.temperature = temperature;
            Console.WriteLine($"Temperature SET: Temperature is set to {temperature} %");
        }
    }
}