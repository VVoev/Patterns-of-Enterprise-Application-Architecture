using System;

namespace AdapterDemo.Models_4demo_
{
    public class MP3 : IMediaPlayer
    {

        public void Play(string filename)
        {
            Console.WriteLine("Playing MP3 File " + filename);
        }
    }
}
