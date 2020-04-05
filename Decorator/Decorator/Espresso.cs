using System;
using System.Collections.Generic;
using System.Text;

namespace Decorator
{
    class Espresso: ICoffee
    {
        private double cost = 3.99;
        private int calories = 2;

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
            return $"Espresso:\nCost: {cost}$   [{calories} kcal]";
        }
    }
}
