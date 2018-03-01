namespace FacadePattern
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class Player : IPlayer
    {
        private readonly ICollection<MediaEntity> playlist;

        private int currentIndex;

        public Player()
        {
            this.playlist = new List<MediaEntity>();
        }

        public void Play()
        {
            if (!this.playlist.Any())
            {
                Console.WriteLine("There are no items on the playlist. Please load some.");
                return;
            }

            var currentPlaylistItem = this.playlist.ElementAtOrDefault(this.currentIndex);

            if (currentPlaylistItem == null)
            {
                Console.WriteLine("The item was not found!");
                return;
            }

            Console.WriteLine("Started playing {0}.{1}", currentPlaylistItem.Title, currentPlaylistItem.FileExtention);
        }

        public void Stop()
        {
            Console.WriteLine("Stop");
            this.currentIndex = 0;
        }

        public void Next()
        {
            this.currentIndex++;
            if (this.currentIndex >= this.playlist.Count)
            {
                this.currentIndex = 0;
            }

            Console.WriteLine("Switching to next item...");
        }

        public void Previous()
        {
            this.currentIndex--;
            if (this.currentIndex < 0)
            {
                this.currentIndex = this.playlist.Count - 1;
            }

            Console.WriteLine("Switching to previous item...");
        }

        public void Load(MediaEntity media)
        {
            this.playlist.Add(media);
            Console.WriteLine("Loaded {0}.{1}", media.Title, media.FileExtention);
        }
    }
}