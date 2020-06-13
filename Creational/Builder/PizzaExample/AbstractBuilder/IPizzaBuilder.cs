using Common.Enums;

namespace Builder.PizzaExample
{
    /// <summary>
    /// Builder Pattern: (Abstract Builder)
    /// </summary>
    public interface IPizzaBuilder
    {
        public PizzaNames Name { get; }
        public SauceTypes Sauce { get; set; }
        public DoughTypes Dough { get; set; }

        Pizza GetPizza();
    }

}
