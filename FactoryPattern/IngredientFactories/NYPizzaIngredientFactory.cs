public class NYPizzaIngredientFactory : PizzaIngredientFactory
{
    public Dough CreateDough()
    {
        return new ThinCrustDough();
    }

    public Sauce CreateSauce()
    {
        return new MarinaraSauce();
    }

    public Cheese CreateCheese()
    {
        return new ReggianoCheese();
    }

    public Clams CreateClam()
    {
        return new FreshClams();
    }
}
