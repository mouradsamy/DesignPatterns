using Common.Enums;

namespace FactoryMethod.PizzaExample
{
    /// <summary>
    /// Overrides the "Factory Method" to return an instance of a "Concrete Product".
    /// </summary>
    class NYPizzaStore : PizzaStore
    {
        public override Pizza CreatePizza(PizzaTypes type)
        {
            return type switch
            {
                PizzaTypes.Cheese => new NYStyleCheesePizza(),
                PizzaTypes.Veggie => new NYStyleVeggiePizza(),
                PizzaTypes.Clam => new NYStyleClamPizza(),
                PizzaTypes.Pepperoni => new NYStylePepperoniPizza(),
                _ => null,
            };
        }
    }
}
