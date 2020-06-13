using Builder.PizzaExample;

using System.Threading;

namespace Builder
{
    public class Program
    {
        static void Main(string[] args)
        {
            RunPizzaExample();
        }

        private static void RunPizzaExample()
        {
            IPizzaBuilder spicyPizzabuilder;
            IPizzaBuilder hawaiianPizzabuilder;
            Waiter waiter;

            spicyPizzabuilder = new SpicyPizzaBuilder();
            waiter = new Waiter(spicyPizzabuilder);
            waiter.Construct();
            waiter.GetPizza();

            Thread.Sleep(2000);

            hawaiianPizzabuilder = new HawaiianPizzaBuilder();
            waiter = new Waiter(hawaiianPizzabuilder);
            waiter.Construct();
            waiter.GetPizza();

            Thread.Sleep(2000);

            spicyPizzabuilder = new SpicyPizzaBuilder();
            waiter = new Waiter(spicyPizzabuilder);
            waiter.Construct();
            waiter.GetPizza();
        }
    }
}
