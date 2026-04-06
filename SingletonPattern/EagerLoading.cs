public class EagerSingleton
{
    private static EagerSingleton uniqueInstance = new();

    private EagerSingleton() { }

    public static EagerSingleton GetInstance()
    {
        return uniqueInstance;
    }
}