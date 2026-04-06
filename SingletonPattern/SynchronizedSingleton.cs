using System.Runtime.CompilerServices;

public class SynchronizedSingleton
{
    private static SynchronizedSingleton uniqueInstance;

    private SynchronizedSingleton() { }

    public static SynchronizedSingleton GetInstance
    {
        [MethodImpl(MethodImplOptions.Synchronized)]
        get
        {
            if (uniqueInstance == null)
            {
                uniqueInstance = new SynchronizedSingleton();
            }
            return uniqueInstance;
        }
    }
}