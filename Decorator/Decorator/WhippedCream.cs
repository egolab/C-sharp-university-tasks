using System;
using System.Collections.Generic;
using System.Text;

namespace Decorator
{
    class WhippedCream : CoffeeDecorator
    {
        private double whippedCreamCost = 1.5;
        private int whippedCreamCalories = 12;

        public WhippedCream(ICoffee coffee) : base(coffee) { }

        public override double Cost()
        {
            return coffee.Cost() + whippedCreamCost;
        }

        public override int Calories()
        {
            return coffee.Calories() + whippedCreamCalories;
        }

        public override string ShowInfo()
        {
            return $"{coffee.ShowInfo()}\n+ {whippedCreamCost}$ Soy Milk [{whippedCreamCalories} kcal]  = {Cost()}$ [{Calories()} kcal]";
        }
    }
}
