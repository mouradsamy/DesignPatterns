using Common.Enums;

using FactoryMethod.PizzaExample;

using System;

namespace FactoryMethod
{
    class Program
    {
        static void Main(string[] args)
        {
            RunPizzaEXample();
            RunPageEXample();
        }

        private static void RunPageEXample()
        {
            Document document = new Resume();
            document.CreatePages();
            foreach (var page in document.Pages)
            {
                Console.WriteLine(page.Title);
            }
        }

        private static void RunPizzaEXample()
        {
            PizzaStore nyStore = new NYPizzaStore();
            PizzaStore chicagoStore = new ChicagoPizzaStore();
            Pizza pizza = nyStore.OrderPizza(PizzaTypes.Cheese);
            Console.WriteLine(pizza.Name);
            pizza = chicagoStore.OrderPizza(PizzaTypes.Cheese);
            Console.WriteLine(pizza.Name);
        }
    }
}
