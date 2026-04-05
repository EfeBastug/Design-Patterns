using System;

public class DesignPatterns{
    // Main Method
    public static void Main(){
        /* Strategy Pattern Example
        Duck mallard = new MallardDuck();
        mallard.Quack();
        mallard.Fly();

        Duck decoy = new DecoyDuck();
        decoy.Quack();
        decoy.setFlyBehaviour(new FlyWithWings());
        decoy.Fly();*/
        
        WeatherData weatherData = new WeatherData();
        CurrentConditionsDisplay currentDisplay = new CurrentConditionsDisplay(weatherData);
        StaticsDisplay staticsDisplay = new StaticsDisplay(weatherData);
        ForecastDisplay forecastDisplay = new ForecastDisplay(weatherData);

        weatherData.SetMeasurements(80, 65, 30.4f);
        weatherData.SetMeasurements(82, 70, 29.2f);
        weatherData.SetMeasurements(78, 90, 29.2f);
    }
}
