public class StaticsDisplay : Observer, DisplayElement
{
    private float temperature;
    private float humidity;
    private float pressure;
    private WeatherData weatherData;

    public StaticsDisplay(WeatherData weatherData)
    {
        this.weatherData = weatherData;
        weatherData.RegisterObserver(this);
    }

    public void Update()
    {
        // Get the latest weather data from the subject
        // For simplicity, we will just assign some dummy values here
        this.temperature = weatherData.GetTemperature();
        this.humidity = weatherData.GetHumidity();
        this.pressure = weatherData.GetPressure();
        Display();
    }

    public void Display()
    {
        Console.WriteLine("Statics Display:");
        Console.WriteLine($"Temperature: {temperature} °C");
        Console.WriteLine($"Humidity: {humidity} %");
        Console.WriteLine($"Pressure: {pressure} hPa");
    }
}