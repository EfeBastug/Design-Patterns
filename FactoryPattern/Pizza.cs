using System.Text;

public abstract class Pizza
{
    public string Name { get; set; }
    public Dough Dough { get; set; }
    public Sauce Sauce { get; set; }
    public Cheese Cheese { get; set; }
    public Clams Clam { get; set; }

    public abstract void Prepare();

    public void Bake()
    {
        Console.WriteLine("Baking for 25 minutes at 350 degrees.");
    }

    public void Cut()
    {
        Console.WriteLine("Cutting the pizza into diagonal slices.");
    }

    public void Box()
    {
        Console.WriteLine("Placing pizza in official PizzaStore box.");
    }

    public override string ToString()
    {
        StringBuilder result = new StringBuilder();
        result.Append("---- " + Name + " ----\n");
        if (Dough != null)
            result.Append(Dough + "\n");
        if (Sauce != null)
            result.Append(Sauce + "\n");
        if (Cheese != null)
            result.Append(Cheese + "\n");
        if (Clam != null)
            result.Append(Clam + "\n");
        return result.ToString();
    }
}
