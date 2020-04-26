using System;
using System.Collections.Generic;

namespace Strategy
{
    class Customer
    {
        private IPriceStrategy priceStrategy;
        private double totalRegularPrice;

        public Customer(Dictionary<double, int> products)
        {
            foreach (KeyValuePair<double, int> kvp in products)
            {
                totalRegularPrice += kvp.Key * kvp.Value;
            }
        }

        public void SetStrategy(IPriceStrategy priceStrategy)
        {
            this.priceStrategy = priceStrategy;
        }

        private double ExecuteDiscount() // execute strategy 
        {
            return priceStrategy.GetReducedPrice(totalRegularPrice);
        }

        public void ShowTotalRegularPrice()
        {
            Console.WriteLine($"Total price before discount: {totalRegularPrice} zł");
        }

        public void ShowTotalReducedPrice()
        {
            Console.WriteLine($"Total price after discount: {ExecuteDiscount()} zł\n");
        }
    }
}