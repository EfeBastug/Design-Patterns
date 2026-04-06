public class SimpleSingleton
{
    private static SimpleSingleton uniqueInstance;

    private SimpleSingleton() { }

    public static SimpleSingleton GetInstance()
    {
        if (uniqueInstance == null)
        {
            uniqueInstance = new SimpleSingleton();
        }
            return uniqueInstance;
    }
}