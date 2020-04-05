using System;
using System.Collections.Generic;
using System.Text;

namespace Decorator
{
    class SoyMilk : CoffeeDecorator
    {
        private double soyMilkCost = 1.5;
        private int soyMilkCalories = 12;

        public SoyMilk(ICoffee coffee) : base(coffee) { }

        public override double Cost()
        {
            return coffee.Cost() + soyMilkCost;
        }

        public override int Calories()
        {
            return coffee.Calories() + soyMilkCalories;
        }

        public override string ShowInfo()
        {
            return $"{coffee.ShowInfo()}\n+ {soyMilkCost}$ Soy Milk [{soyMilkCalories} kcal]  = {Cost()}$ [{Calories()} kcal]";
        }
    }
}
