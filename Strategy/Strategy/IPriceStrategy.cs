using System;

namespace Strategy
{
    interface IPriceStrategy
    {
        double GetReducedPrice(double totalRegularPrice);
    }

    public class PercentDiscountStrategy : IPriceStrategy // decrease total price by given %
    {
        private int percent;

        public PercentDiscountStrategy(int percent) 
        {
            this.percent = percent;
        }

        public double GetReducedPrice(double totalRegularPrice)
        {
            return Math.Round(totalRegularPrice * (100 - percent) / 100, 2);
        }
    }

    public class AmountDiscountStrategy : IPriceStrategy // if total regular price exceedes 100 zł it is reduced by 30 zł
    {
        public double GetReducedPrice(double totalRegularPrice)
        {
            if (totalRegularPrice > 100)
            {
                return totalRegularPrice - 30;
            }
            else return totalRegularPrice;
        }
    }
}