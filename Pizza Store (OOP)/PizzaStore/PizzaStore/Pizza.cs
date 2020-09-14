using System;
using System.Collections.Generic;
using System.Text;

namespace PizzaStore
{
    public abstract class Pizza
    {
        protected string name;
        protected string dough;
        protected string sauce;
        protected List<string> toppings = new List<string>();


        public void Prepare()
        {
            Console.WriteLine("Preparing: "+ name);
            Console.WriteLine("Tossing dough......" + dough);
            Console.WriteLine("Adding sauce....." + sauce);
            Console.WriteLine("Adding Toppings: ");
            toppings?.ForEach((toppings) 
                => Console.WriteLine("\t" + toppings));
        }
        public void Bake()
        {
            Console.WriteLine("Baking " + name +" "+ "in 35 minutes");
        }

        public void Cut()
        {
            Console.WriteLine("Cutting " + name );
        }

        public void Box()
        {
            Console.WriteLine("Boxing " + name);
        }
    }
}
