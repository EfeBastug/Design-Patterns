public class ChicagoPizzaStore : PizzaStore
{
    protected override Pizza CreatePizza(string item)
    {
        Pizza pizza = null;
        PizzaIngredientFactory ingredientFactory = new ChicagoPizzaIngredientFactory();

        if (item == "cheese")
        {
            pizza = new CheesePizza(ingredientFactory);
            pizza.Name = "Chicago Style Cheese Pizza";
        }
        else if (item == "clam")
        {
            pizza = new ClamPizza(ingredientFactory);
            pizza.Name = "Chicago Style Clam Pizza";
        }

        return pizza;
    }
}
