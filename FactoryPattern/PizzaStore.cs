public abstract class PizzaStore
{
    public Pizza OrderPizza(string type)
    {
        Pizza pizza = CreatePizza(type);

        Console.WriteLine("--- Making a " + pizza.Name + " ---");
        pizza.Prepare();
        pizza.Bake();
        pizza.Cut();
        pizza.Box();

        return pizza;
    }

    protected abstract Pizza CreatePizza(string type);
}
