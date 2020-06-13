using Common.Enums;

namespace FactoryMethod.PizzaExample
{
    public abstract class PizzaStore
    {
        public Pizza OrderPizza(PizzaTypes type)
        {
            Pizza pizza = CreatePizza(type);
            pizza.Prepare();
            pizza.Bake();
            pizza.Cut();
            pizza.Box();
            return pizza;
        }

        /// <summary>
        /// The "Factory Method" that must be implemented by subclasses.
        /// </summary>
        /// <param name="type">The type of the required Pizza</param>
        /// <returns>One of the Pizza subclasses' object.</returns>

        public abstract Pizza CreatePizza(PizzaTypes type);
    }
}
