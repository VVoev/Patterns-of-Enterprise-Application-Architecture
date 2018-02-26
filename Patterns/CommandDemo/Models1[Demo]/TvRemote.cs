namespace CommandDemo.Models1_Demo_
{
    public class TvRemote
    {
        public static IElectronicDevice getDevice()
        {
            return new Television();
        }
    }
}
