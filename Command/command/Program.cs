using System;

namespace command
{
    class Program
    {
        static void Main(string[] args)
        {
            RemoteControl control = new RemoteControl();

            Light light = new Light();
            ICommand lightOn = new SwitchOnCommand(light);
            ICommand upDimness = new UpCommand(light);
            ICommand downDimness = new DownCommand(light);
            ICommand setDimness = new SetValueCommand(light, 100);
            ICommand lightOff = new SwitchOffCommand(light);

            AirConditioning airConditioning = new AirConditioning();
            ICommand airConditionerOn = new SwitchOnCommand(airConditioning);
            ICommand upTemperature = new UpCommand(airConditioning);
            ICommand dowmTemperature = new DownCommand(airConditioning);
            ICommand setTemperature = new SetValueCommand(airConditioning, 25);
            ICommand airConditionerOff = new SwitchOffCommand(airConditioning);

            control.SetCommand(lightOn);
            control.PressButton();
            control.SetCommand(upDimness);
            control.PressButton();
            control.SetCommand(setDimness);
            control.PressButton();
            control.SetCommand(downDimness);
            control.PressButton();
            control.SetCommand(lightOff);
            control.PressButton();
            Console.WriteLine();

            control.SetCommand(airConditionerOn);
            control.PressButton();
            control.SetCommand(upTemperature);
            control.PressButton();
            control.SetCommand(dowmTemperature);
            control.PressButton();
            control.SetCommand(setTemperature);
            control.PressButton();
            control.SetCommand(airConditionerOff);
            control.PressButton();
        }
    }
}
