public class NYPizzaStore : PizzaStore
{
    protected override Pizza CreatePizza(string item)
    {
        Pizza pizza = null;
        PizzaIngredientFactory ingredientFactory = new NYPizzaIngredientFactory();

        if (item == "cheese")
        {
            pizza = new CheesePizza(ingredientFactory);
            pizza.Name = "New York Style Cheese Pizza";
        }
        else if (item == "clam")
        {
            pizza = new ClamPizza(ingredientFactory);
            pizza.Name = "New York Style Clam Pizza";
        }

        return pizza;
    }
}
