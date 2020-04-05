using System;
using System.Collections.Generic;
using System.Text;

namespace Decorator
{
    class Latte: ICoffee
    {
        private double cost = 6.99;
        private int calories = 55;

        public double Cost()
        {
            return cost;
        }

        public int Calories()
        {
            return calories;
        }

        public string ShowInfo()
        {
            return $"Latte:\nCost: {cost}$   [{calories} kcal]";
        }
    }
}
