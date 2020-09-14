using System;
using System.Collections.Generic;
using System.Text;

namespace PizzaStore
{
    class PizzaStore
    {
        public void OderPizza(string type)
        {
            Pizza pizza;
            switch (type)
            {
                case "cheese":
                    pizza = new CheesePizza();
                    break;
                case "greek":
                    pizza = new GreakPizza();
                    break;
                case "pepperoni":
                    pizza = new PepperoniPizza();
                    break;
                default:
                    Console.WriteLine("we do not have "+ type);
                    return;
            }

            pizza.Prepare();
            pizza.Bake();
            pizza.Cut();
            pizza.Box();
        }
    }
}
