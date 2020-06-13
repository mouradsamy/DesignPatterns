using Builder.Enums;

namespace Builder
{
    /// <summary>
    /// Builder Pattern: (Abstract Builder)
    /// </summary>
    public interface IPizzaBuilder
    {
        public PizzaTypes Type { get; }
        public SauceTypes Sauce { get; set; }
        public DoughTypes Dough { get; set; }

        Pizza GetPizza();
    }

}
