namespace SingletonDemo.LockSingleton
{
    public sealed class LockedSingleton
    {
        private static volatile LockedSingleton instance;
        private static object syncRoot = new object();

        private LockedSingleton() { }

        public static LockedSingleton Instance
        {
            get
            {
                if (instance == null)
                {
                    lock (syncRoot)
                    {
                        if (instance == null)
                            instance = new LockedSingleton();
                    }
                }

                return instance;
            }
        }
    }

}
