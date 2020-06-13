using Common.Enums;
using Common.Extensions;

using System;
using System.Linq;

namespace Builder.PizzaExample
{
    /// <summary>
    /// Builder Pattern: (Director)
    /// </summary> 
    class Waiter
    {
        private readonly IPizzaBuilder pizzaBuilder;

        public Waiter(IPizzaBuilder pb)
        {
            pizzaBuilder = pb;
        }

        public Pizza GetPizza()
        {
            Pizza pizza = pizzaBuilder.GetPizza();
            PrintPizza(pizza);
            return pizza;
        }

        public void Construct()
        {
            pizzaBuilder.Sauce = SauceTypes.Marinara;
            pizzaBuilder.Dough = DoughTypes.ExtraThickCrust;
        }

        public void PrintPizza(Pizza pizza)
        {
            Console.WriteLine("*************************** New Pizza ***************************");
            Console.WriteLine(EnumExtensions<PizzaNames>.GetDisplayValue(pizza.Name));
            Console.WriteLine("Dough:- " + pizza.Dough);
            Console.WriteLine("Sauce:- " + pizza.Sauce);
            Console.Write("Toppings:- ");
            if (pizza.Toppings.Length > 0)
            {

                foreach (var topping in pizza.Toppings)
                {
                    var isLast = pizza.Toppings.Last().Equals(topping);
                    if (isLast)
                    {
                        Console.WriteLine(topping.ToString());
                    }
                    else
                    {
                        Console.Write(topping.ToString() + ", ");
                    }
                }
            }
            else
            {
                Console.WriteLine("N/A");
            }
            Console.WriteLine();
            Console.WriteLine("*****************************************************************");
        }
    }
}
