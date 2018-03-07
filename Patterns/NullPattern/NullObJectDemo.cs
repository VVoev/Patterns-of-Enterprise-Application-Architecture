using NullPattern.Models_1demo_;

namespace NullPattern
{
    public class NullObJectDemo
    {
        public static void FirstDemo()
        {
            var autoRepository = new AutoRepository();
            var automobile = autoRepository.Find("BmwM3");
            automobile.Start();
            automobile.Stop();

            var another = autoRepository.Find("LexusLs");
            another.Start();
            another.Stop();
        }
    }
}