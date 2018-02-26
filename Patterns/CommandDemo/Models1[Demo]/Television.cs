using System;

namespace CommandDemo.Models1_Demo_
{
    public class Television : IElectronicDevice
    {
        private int volume;
        public void Off()
        {
            Console.WriteLine($"{this.GetType().Name} is Off");
        }

        public void On()
        {
            Console.WriteLine($"{this.GetType().Name} is Onn");
        }

        public void VolumeDown()
        {
            --volume;
            Console.WriteLine($"{this.GetType().Name} volume down {volume}");
        }

        public void VolumeUp()
        {
            ++volume;
            Console.WriteLine($"{this.GetType().Name} volume up {volume}");
        }
    }

}
