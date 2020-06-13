using System;
using System.Linq;

namespace Builder
{
    /// <summary>
    /// Builder Pattern: (Director)
    /// </summary> 
    class Waiter
    {
        private PizzaBuilder pizzaBuilder;

        public void SetPizzaBuilder(PizzaBuilder pb)
        {
            pizzaBuilder = pb;
        }

        public Pizza GetPizza()
        {
            Pizza pizza = pizzaBuilder.GetPizza();
            PrintPizza(pizza);
            return pizza;
        }

        public void ConstructPizza()
        {
            pizzaBuilder.CreateNewPizza();
            pizzaBuilder.BuildDough();
            pizzaBuilder.BuildSauce();
            pizzaBuilder.BuildTopping();
        }

        public void PrintPizza(Pizza pizza)
        {
            Console.WriteLine("*************************** New Pizza ***************************");
            Console.WriteLine();
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
