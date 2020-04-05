using System;
using System.Collections.Generic;
using System.Text;

namespace Decorator
{
    abstract class CoffeeDecorator: ICoffee
    {
        protected ICoffee coffee;

        abstract public double Cost();

        abstract public int Calories();

        public CoffeeDecorator(ICoffee coffee)
        {
            this.coffee = coffee;
        }

        public abstract string ShowInfo();
    }
}
