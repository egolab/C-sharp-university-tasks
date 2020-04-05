using System;

namespace Decorator
{
    class Program
    {
        static void Main(string[] args)
        {
            ICoffee latte = new Latte();
            latte = new WhippedCream(latte);
            latte = new Caramel(latte);
            latte = new SoyMilk(latte);
            Console.WriteLine(latte.ShowInfo());
            Console.WriteLine();

            ICoffee espresso = new Espresso();
            Console.WriteLine(espresso.ShowInfo());
            Console.WriteLine();

            ICoffee cappuccino = new Cappuccino();
            cappuccino = new SoyMilk(cappuccino);
            cappuccino = new Caramel(cappuccino);
            Console.WriteLine(cappuccino.ShowInfo());
        }
    }
}
