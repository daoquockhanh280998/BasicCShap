using System;
using System.Collections.Generic;
using System.Text;

namespace PizzaStore
{
    class CheesePizza :Pizza
    {
        public CheesePizza()
        {
            name = "The Best cheese pizza";
            dough = "very thin dough";
            sauce = "very spice sauce";
            toppings.Add("Black olives");
            toppings.Add("cheese");
        }
    }
}
