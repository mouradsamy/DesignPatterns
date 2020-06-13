using Builder.Enums;

namespace Builder
{
    /// <summary>
    /// Builder Pattern: (Concrete Builder)
    /// </summary>
    class SpicyPizzaBuilder : IPizzaBuilder
    {
        public SauceTypes Sauce { get; set; }
        public DoughTypes Dough { get; set; }
        public PizzaTypes Type => PizzaTypes.Spicy;

        public Pizza GetPizza()
        {
            Sauce = SauceTypes.Hot;
            Dough = DoughTypes.Cross;
            var toppings = new[] { ToppingTypes.Ham, ToppingTypes.Pepperoni };

            return new Pizza(Type, Dough, Sauce, toppings);
        }
    }

}
