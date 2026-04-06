public class DoubleCheckedSingleton
{
    private volatile static DoubleCheckedSingleton uniqueInstance;
    private static readonly object syncLock = new object();

    private DoubleCheckedSingleton() { }

    public static DoubleCheckedSingleton GetInstance()
    {
        if (uniqueInstance == null)
        {
            lock (syncLock)
            {
                if (uniqueInstance == null)
                {
                    uniqueInstance = new DoubleCheckedSingleton();
                }
            }
        }
        return uniqueInstance;
    }
}
