using System;
using System.Collections.Generic;
using System.Text;

namespace Decorator
{
    class Cappuccino: ICoffee
    {
        private double cost = 6.99;
        private int calories = 90;

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
            return $"Cappuccino:\nCost: {cost}$   [{calories} kcal]";
        }
    }
}
