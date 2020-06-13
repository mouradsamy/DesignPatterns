using Common.Enums;

namespace Builder.PizzaExample
{
    /// <summary>
    /// Builder Pattern: (Product)
    /// </summary>
    public class Pizza
    {
        public PizzaNames Name { get; }
        public DoughTypes Dough { get; set; }
        public SauceTypes Sauce { get; set; }
        public ToppingTypes[] Toppings { get; set; }

        public Pizza(PizzaNames name, DoughTypes dough, SauceTypes sauce, ToppingTypes[] toppings)
        {
            Name = name;
            Dough = dough;
            Sauce = sauce;
            Toppings = toppings;
        }
    }
}
