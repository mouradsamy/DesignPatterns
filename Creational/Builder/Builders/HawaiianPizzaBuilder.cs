using Builder.Enums;

namespace Builder
{
    /// <summary>
    /// Builder Pattern: (Concrete Builder)
    /// </summary>
    public class HawaiianPizzaBuilder : PizzaBuilder
    {
        public override void BuildDough()
        {
            pizza.Dough = DoughTypes.PanBaked;
        }

        public override void BuildSauce()
        {
            pizza.Sauce = SauceTypes.Mild;
        }

        public override void BuildTopping()
        {
            pizza.Toppings = new[] { ToppingTypes.Pineapple, ToppingTypes.Salami };
        }
    }
}
