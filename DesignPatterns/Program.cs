using System;

public class DesignPatterns
{
    // Main Method
    public static void Main(){
        /*
        // Strategy Pattern Example
        Duck mallard = new MallardDuck();
        mallard.Quack();
        mallard.Fly();

        Duck decoy = new DecoyDuck();
        decoy.Quack();
        decoy.setFlyBehaviour(new FlyWithWings());
        decoy.Fly();

        // Observer Pattern Example
        WeatherData weatherData = new WeatherData();
        CurrentConditionsDisplay currentDisplay = new CurrentConditionsDisplay(weatherData);
        StaticsDisplay staticsDisplay = new StaticsDisplay(weatherData);
        ForecastDisplay forecastDisplay = new ForecastDisplay(weatherData);

        weatherData.SetMeasurements(80, 65, 30.4f);
        weatherData.SetMeasurements(82, 70, 29.2f);
        weatherData.SetMeasurements(78, 90, 29.2f);

        // Decorator Pattern Example
        Beverage beverage = new Espresso();
        Console.WriteLine($"{beverage.GetDescription()} ${beverage.Cost()}");

        Beverage beverage2 = new DarkRoast();
        beverage2 = new Mocha(beverage2);
        beverage2 = new Mocha(beverage2);
        beverage2 = new Whip(beverage2);
        Console.WriteLine($"{beverage2.GetDescription()} ${beverage2.Cost()}");

        Beverage beverage3 = new DarkRoast();
        beverage3 = new Soy(beverage3);
        beverage3 = new Mocha(beverage3);
        beverage3 = new Whip(beverage3);
        Console.WriteLine($"{beverage3.GetDescription()} ${beverage3.Cost()}");
        */

        // Factory Pattern Example
        PizzaStore nyStore = new NYPizzaStore();
        PizzaStore chicagoStore = new ChicagoPizzaStore();

        Pizza pizza = nyStore.OrderPizza("cheese");
        Console.WriteLine("Ethan ordered a " + pizza.Name + "\n");
        Console.WriteLine(pizza);

        pizza = chicagoStore.OrderPizza("cheese");
        Console.WriteLine("Joel ordered a " + pizza.Name + "\n");
        Console.WriteLine(pizza);

        pizza = nyStore.OrderPizza("clam");
        Console.WriteLine("Ethan ordered a " + pizza.Name + "\n");
        Console.WriteLine(pizza);

        pizza = chicagoStore.OrderPizza("clam");
        Console.WriteLine("Joel ordered a " + pizza.Name + "\n");
        Console.WriteLine(pizza);
    }
}
