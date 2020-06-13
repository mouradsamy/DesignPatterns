using Common.Enums;

namespace Builder.PizzaExample
{
    /// <summary>
    /// Builder Pattern: (Concrete Builder)
    /// </summary>
    public class HawaiianPizzaBuilder : IPizzaBuilder
    {
        public PizzaNames Name => PizzaNames.NYStyleCheesePizza;
        public SauceTypes Sauce { get; set; }
        public DoughTypes Dough { get; set; }

        public Pizza GetPizza()
        {
            Sauce = SauceTypes.Marinara;
            Dough = DoughTypes.ExtraThickCrust;
            var toppings = new[] { ToppingTypes.Pineapple, ToppingTypes.Salami };

            return new Pizza(Name, Dough, Sauce, toppings);
        }
    }
}
