using Common.Enums;

namespace Builder.PizzaExample
{
    /// <summary>
    /// Builder Pattern: (Concrete Builder)
    /// </summary>
    class SpicyPizzaBuilder : IPizzaBuilder
    {
        public PizzaNames Name => PizzaNames.ChicagoStyleCheesePizza;
        public SauceTypes Sauce { get; set; }
        public DoughTypes Dough { get; set; }

        public Pizza GetPizza()
        {
            Sauce = SauceTypes.Marinara;
            Dough = DoughTypes.ThinCrust;
            var toppings = new[] { ToppingTypes.Ham, ToppingTypes.Pepperoni };

            return new Pizza(Name, Dough, Sauce, toppings);
        }
    }

}
