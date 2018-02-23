using System;

namespace AdapterDemo.Models_4demo_
{
    public class MP4 : IMediaPackage
    {

        public void PlayFile(String filename)
        {
            Console.WriteLine("Playing MP4 File " + filename);
        }
    }
}
