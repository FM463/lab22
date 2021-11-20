using System;
using System.Collections.Generic;
using System.Text;

namespace Pizza
{
    class CocktailCreator : Creator
    {
        public override Product FactoryMethod()
        {
            return new Cocktail();
        }
    }
}