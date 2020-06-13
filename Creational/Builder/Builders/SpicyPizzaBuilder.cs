using Builder.Enums;

namespace Builder
{
    /// <summary>
    /// Builder Pattern: (Concrete Builder)
    /// </summary>
    class SpicyPizzaBuilder : PizzaBuilder
    {
        public override void BuildDough()
        {
            pizza.Dough = DoughTypes.Cross;
        }

        public override void BuildSauce()
        {
            pizza.Sauce = SauceTypes.Hot;
        }

        public override void BuildTopping()
        {
            pizza.Toppings = new[] { ToppingTypes.Ham, ToppingTypes.Pepperoni };
        }
    }

}
