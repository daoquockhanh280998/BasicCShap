using System;
using System.Collections.Generic;
using System.Text;

namespace PizzaStore
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;

            var pizzaStore = new PizzaStore();
            pizzaStore.OderPizza("cheese");
            Console.WriteLine("\n");
            pizzaStore.OderPizza("greek");
            Console.WriteLine("\n");
            pizzaStore.OderPizza("pepperoni");

        }
    }
}
