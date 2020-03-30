using System;

namespace GUIFactory
{
    class Program
    {
        static void Main(string[] args)
        {
            WindowsGUIFactory windowsGUIFactory = new WindowsGUIFactory();
            IButton windowsButton = windowsGUIFactory.CreateButton();
            IDialog windowsDialog = windowsGUIFactory.CreateDialog();
            Console.WriteLine(windowsButton.ShowData());
            Console.WriteLine(windowsDialog.ShowData());
            Console.WriteLine();

            LinuxGUIFactory linuxGUIFactory = new LinuxGUIFactory();
            IButton linuxButton = linuxGUIFactory.CreateButton();
            IDialog linuxDialog = linuxGUIFactory.CreateDialog();
            Console.WriteLine(linuxButton.ShowData());
            Console.WriteLine(linuxDialog.ShowData());
        }
    }
}
