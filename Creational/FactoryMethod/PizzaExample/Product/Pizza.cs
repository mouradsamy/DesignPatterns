using Common.Enums;

using System;
using System.Collections.Generic;
namespace FactoryMethod.PizzaExample
{
    public abstract class Pizza
    {
        public PizzaNames Name { get; set; }
        public DoughTypes Dough { get; set; }
        public SauceTypes Sauce { get; set; }
        public List<ToppingTypes> Toppings { get; set; }

        public void Prepare()
        {
            Console.WriteLine("Preparing " + Name);
            Console.WriteLine("Tossing dough...");
            Console.WriteLine("Adding sauce...");
            Console.WriteLine("Adding toppings: ");
            foreach (var topping in Toppings)
            {
                Console.WriteLine(" " + topping);
            }
        }

        public void Bake()
        {
            Console.WriteLine("Bake for 25 minutes at 350");
        }
        public void Cut()
        {
            Console.WriteLine("Cutting the pizza into diagonal slices");
        }
        public void Box()
        {
            Console.WriteLine("Place pizza in official PizzaStore box");
        }
    }
}