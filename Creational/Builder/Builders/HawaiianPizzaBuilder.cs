using Builder.Enums;

namespace Builder
{
    /// <summary>
    /// Builder Pattern: (Concrete Builder)
    /// </summary>
    public class HawaiianPizzaBuilder : IPizzaBuilder
    {
        public PizzaTypes Type => PizzaTypes.Hawaiian;
        public SauceTypes Sauce { get; set; }
        public DoughTypes Dough { get; set; }

        public Pizza GetPizza()
        {
            Sauce = SauceTypes.Mild;
            Dough = DoughTypes.Cross;
            var toppings = new[] { ToppingTypes.Pineapple, ToppingTypes.Salami };

            return new Pizza(Type, Dough, Sauce, toppings);
        }
    }
}
