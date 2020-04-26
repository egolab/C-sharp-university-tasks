using System;
using System.Collections.Generic;

namespace Strategy
{
    class Program
    {
        static void Main(string[] args)
        {
            Customer customer1 = new Customer(new Dictionary<double, int>(){{10.5, 2 }, {3.25, 1 }, {0.99, 4 }});
            IPriceStrategy priceStrategy1 = new PercentDiscountStrategy(30);

            Console.WriteLine("Customer 1");
            customer1.ShowTotalRegularPrice();
            customer1.SetStrategy(priceStrategy1);
            customer1.ShowTotalReducedPrice();

            Customer customer2 = new Customer(new Dictionary<double, int>() { { 15.25, 2 }, { 33.99, 2 }, { 0.99, 4 } });
            IPriceStrategy priceStrategy2 = new AmountDiscountStrategy();

            Console.WriteLine("Customer 2");
            customer2.ShowTotalRegularPrice();
            customer2.SetStrategy(priceStrategy2);
            customer2.ShowTotalReducedPrice();
        }
    }
}