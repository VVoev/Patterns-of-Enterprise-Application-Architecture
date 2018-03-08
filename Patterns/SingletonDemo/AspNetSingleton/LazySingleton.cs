namespace SingletonDemo.AspNetSingleton
{
    //TS Suitable for WEB

    public class LazySingleton
    {
        private LazySingleton()
        {

        }

        public static LazySingleton Instance
        {
            get
            {
                return Nested.instance;
            }
        }

        private class Nested
        {
            static Nested()
            {

            }

            internal static readonly LazySingleton instance = new LazySingleton();
        }
    }
}
