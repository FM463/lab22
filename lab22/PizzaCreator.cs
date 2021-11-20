using System;
using System.Collections.Generic;
using System.Text;

namespace Pizza
{
    class PizzaCreator : Creator
    {
        public override Product FactoryMethod()
        {
            return new Pizza();
        }
    }
}