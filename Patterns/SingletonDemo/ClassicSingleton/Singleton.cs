namespace SingletonDemo.ClassicSingleton
{
    //clasic singgleton NOT TS
    public class Singleton
    {
        private static Singleton instance;

        private Singleton()
        {

        }

        public static Singleton Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new Singleton();
                }

                return instance;
            }
        }
    }
}
