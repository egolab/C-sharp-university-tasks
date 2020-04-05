using System;
using System.Collections.Generic;
using System.Text;

namespace Decorator
{
    class Caramel : CoffeeDecorator
    {
        public Caramel(ICoffee coffee) : base(coffee) { }


        double caramelCost = 2.5;
        int caramelCalories = 15;

        public override double Cost()
        {
            return coffee.Cost() + caramelCost;
        }

         public override int Calories()
         {
             return coffee.Calories() + caramelCalories;
         }

        public override string ShowInfo()
        {
            return $"{coffee.ShowInfo()}\n+ {caramelCost}$ Caramel [{caramelCalories} kcal] = {Cost()}$ [{Calories()} kcal]";
        }
    }
}
