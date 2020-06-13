using Common.Enums;

namespace FactoryMethod.PizzaExample
{
    /// <summary>
    /// Overrides the "Factory Method" to return an instance of a "Concrete Product".
    /// </summary>
    class ChicagoPizzaStore : PizzaStore
    {
        public override Pizza CreatePizza(PizzaTypes type)
        {
            return type switch
            {
                PizzaTypes.Cheese => new ChicagoStyleCheesePizza(),
                PizzaTypes.Veggie => new ChicagoStyleVeggiePizza(),
                PizzaTypes.Clam => new ChicagoStyleClamPizza(),
                PizzaTypes.Pepperoni => new ChicagoStylePepperoniPizza(),
                _ => null,
            };
        }
    }
}
