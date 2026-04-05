public class WeatherData : Subject
{
    private List<Observer> observers;
    private float temperature;
    private float humidity;
    private float pressure;

    public WeatherData()
    {
        observers = [];
    }

    public float GetTemperature()
    {
        return temperature;
    }

    public float GetHumidity()
    {
        return humidity;
    }

    public float GetPressure()
    {
        return pressure;
    }

    public void RegisterObserver(Observer o)
    {
        observers.Add(o);
    }

    public void RemoveObserver(Observer o)
    {
        observers.Remove(o);
    }

    public void NotifyObservers()
    {
        foreach (Observer observer in observers)
        {
            observer.Update();
        }
    }

    public void MeasurementsChanged()
    {
        NotifyObservers();
    }

    public void SetMeasurements(float temperature, float humidity, float pressure)
    {
        this.temperature = temperature;
        this.humidity = humidity;
        this.pressure = pressure;
        MeasurementsChanged();
    }
}