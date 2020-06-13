using Common.Enums;

using System.Collections.Generic;

namespace FactoryMethod.PizzaExample
{
    /// <summary>
    /// A 'ConcreteProduct' class which implements the Product interface.
    /// </summary>
    public class NYStyleVeggiePizza : Pizza
    {
        public NYStyleVeggiePizza()
        {
            Name = PizzaNames.NYStyleCheesePizza;
            Dough = DoughTypes.ExtraThickCrust;
            Sauce = SauceTypes.Marinara;
            Toppings = new List<ToppingTypes> { ToppingTypes.Ham, ToppingTypes.GratedReggianoCheese };
        }
    }
}
