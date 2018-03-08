using SingletonDemo.AspNetSingleton;
using SingletonDemo.ClassicSingleton;
using SingletonDemo.LockSingleton;

namespace SingletonDemo
{
    public class Initialize
    {
        public static void FirstDemo()
        {
            var classicSingleton = Singleton.Instance;
            var AspSingleton = LazySingleton.Instance;
            var lockSingleton = LockedSingleton.Instance;
     
        }
    }
}