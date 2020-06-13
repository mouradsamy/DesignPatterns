using Builder.Enums;

namespace Builder
{
    /// <summary>
    /// Builder Pattern: (Product)
    /// </summary>
    public class Pizza
    {
        public PizzaTypes? Type { get; }
        public DoughTypes? Dough { get; set; }
        public SauceTypes? Sauce { get; set; }
        public ToppingTypes[] Toppings { get; set; }

        public Pizza(PizzaTypes type, DoughTypes dough, SauceTypes sauce, ToppingTypes[] toppings)
        {
            Type = type;
            Dough = dough;
            Sauce = sauce;
            Toppings = toppings;
        }
    }
}
