using Common.Enums;

using System.Collections.Generic;

namespace FactoryMethod.PizzaExample
{
    /// <summary>
    /// A 'ConcreteProduct' class which implements the Product interface.
    /// </summary>
    public class NYStylePepperoniPizza : Pizza
    {
        public NYStylePepperoniPizza()
        {
            Name = PizzaNames.NYStyleCheesePizza;
            Dough = DoughTypes.ExtraThickCrust;
            Sauce = SauceTypes.Marinara;
            Toppings = new List<ToppingTypes> { ToppingTypes.Ham, ToppingTypes.GratedReggianoCheese };
        }
    }
}
