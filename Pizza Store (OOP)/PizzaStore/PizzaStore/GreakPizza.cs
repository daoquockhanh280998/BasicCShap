using System;
using System.Collections.Generic;
using System.Text;

namespace PizzaStore
{
    class GreakPizza :Pizza
    {
        public GreakPizza()
        {
            name = "The Best Greak Pizza";
            dough = " thin dough";
            sauce = " chilli sauce";
            toppings.Add("tomato");
            toppings.Add("pomato");
        }
    }
}
