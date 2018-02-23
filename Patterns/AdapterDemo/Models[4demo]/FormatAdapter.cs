using System;

namespace AdapterDemo.Models_4demo_
{
    public class FormatAdapter : IMediaPlayer
    {
        private IMediaPackage mediaPackage;
        public FormatAdapter(IMediaPackage mediaPackage)
        {
            this.mediaPackage = mediaPackage;
        }

        public void Play(string filename)
        {
            Console.WriteLine("Using Adapter --> ");
            this.mediaPackage.PlayFile(filename);
        }
    }
}
