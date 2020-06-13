namespace Builder
{
    /// <summary>
    /// Builder Pattern: (Abstract Builder)
    /// </summary>
    public abstract class PizzaBuilder
    {
        protected Pizza pizza;

        public Pizza GetPizza()
        {
            return pizza;
        }

        public void CreateNewPizza()
        {
            pizza = new Pizza();
        }

        public abstract void BuildDough();
        public abstract void BuildSauce();
        public abstract void BuildTopping();
    }

}
