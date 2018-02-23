using System;

namespace AdapterDemo.Models_4demo_
{
    public class VLC : IMediaPackage
    {

        public void PlayFile(String filename)
        {
            Console.WriteLine("Playing VLC File " + filename);
        }
    }
}
