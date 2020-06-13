using Builder.Enums;

using System;
using System.Linq;

namespace Builder
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
            pizzaBuilder.Sauce = SauceTypes.Hot;
            pizzaBuilder.Dough = DoughTypes.Cross;
        }

        public void PrintPizza(Pizza pizza)
        {
            Console.WriteLine("*************************** New Pizza ***************************");
            Console.WriteLine(pizza.Type.ToString());
            Console.WriteLine("Dough:- " + (pizza.Dough.HasValue ? pizza.Dough.ToString() : "N/A"));
            Console.WriteLine("Sauce:- " + (pizza.Sauce.HasValue ? pizza.Sauce.ToString() : "N/A"));
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
