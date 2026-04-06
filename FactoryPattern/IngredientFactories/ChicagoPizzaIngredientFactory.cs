public class ChicagoPizzaIngredientFactory : PizzaIngredientFactory
{
    public Dough CreateDough()
    {
        return new ThickCrustDough();
    }

    public Sauce CreateSauce()
    {
        return new PlumTomatoSauce();
    }

    public Cheese CreateCheese()
    {
        return new MozzarellaCheese();
    }

    public Clams CreateClam()
    {
        return new FrozenClams();
    }
}
