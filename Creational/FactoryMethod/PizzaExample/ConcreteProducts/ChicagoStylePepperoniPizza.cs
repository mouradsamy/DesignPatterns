using Common.Enums;

using System.Collections.Generic;

namespace FactoryMethod.PizzaExample
{
    /// <summary>
    /// A 'ConcreteProduct' class which implements the Product interface.
    /// </summary>
    public class ChicagoStylePepperoniPizza : Pizza
    {
        public ChicagoStylePepperoniPizza()
        {
            Name = PizzaNames.ChicagoStyleCheesePizza;
            Dough = DoughTypes.ThinCrust;
            Sauce = SauceTypes.PlumTomato;
            Toppings = new List<ToppingTypes> { ToppingTypes.Pineapple, ToppingTypes.Salami };
        }
    }
}
