using Builder.Enums;

namespace Builder
{
    /// <summary>
    /// Builder Pattern: (Product)
    /// </summary>
    public class Pizza
    {
        public DoughTypes? Dough { get; set; }
        public SauceTypes? Sauce { get; set; }
        public ToppingTypes[] Toppings { get; set; }
    }
}
