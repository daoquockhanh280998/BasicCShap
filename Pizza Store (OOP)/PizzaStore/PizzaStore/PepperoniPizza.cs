using System;
using System.Collections.Generic;
using System.Text;

namespace PizzaStore
{
    class PepperoniPizza : Pizza
    {
        public PepperoniPizza()
        {
            name = "The Best Pepperoni Pizza";
            dough = "thick dough";
            sauce = "very spice sauce";
            toppings.Add("Tomato");
           
        }
    }
}
