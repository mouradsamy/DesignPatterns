namespace Builder
{
    public class Program
    {
        static void Main(string[] args)
        {
            Waiter waiter = new Waiter();
            PizzaBuilder hawaiianPizzabuilder = new HawaiianPizzaBuilder();

            waiter.SetPizzaBuilder(hawaiianPizzabuilder);
            waiter.ConstructPizza();
            waiter.GetPizza();
        }
    }
}
