namespace FacadePattern
{
    using System;

    /// <summary>
    /// The Facade
    /// </summary>
    public class HomeTheaterPro
    {
        private readonly Database db = new Database();
        private readonly Player player = new Player();
        private readonly InteriorController roomControll = new InteriorController();

        private HomeTheaterPro()
        {
            this.SeedDatabase(); // For testing
        }

        public static HomeTheaterPro CreateInstance()
        {
            return new HomeTheaterPro();
        }

        public void DisplayAvailableMedia()
        {
            var allMedia = this.db.GetAvailableMedia();

            foreach (var entity in allMedia)
            {
                Console.WriteLine("{0} - {1} minutes", entity.Title, entity.FileExtention);
            }
        }

        public void InitHomeSystem()
        {
            Console.WriteLine();
            Console.WriteLine(string.Empty.PadLeft(30, '='));
            Console.WriteLine();
            this.roomControll.DimLights(15);
            this.roomControll.MoveCurtains(0);
            this.roomControll.HideTable();
            Console.WriteLine();
            Console.WriteLine(string.Empty.PadLeft(30, '='));
            Console.WriteLine();
            this.LoadMedia();
            Console.WriteLine();
            Console.WriteLine(string.Empty.PadLeft(30, '='));
            Console.WriteLine();
            this.player.Play();
        }

        public void Next()
        {
            this.player.Next();
            this.player.Play();
        }

        public void Previous()
        {
            this.player.Previous();
            this.player.Play();
        }

        public void Stop()
        {
            this.player.Stop();
        }

        private void LoadMedia()
        {
            var allMedia = this.db.GetAvailableMedia();

            foreach (var entity in allMedia)
            {
                this.player.Load(entity);
            }
        }

        private void SeedDatabase()
        {
            this.db.Add(new MediaEntity
            {
                Title = "Stardust",
                FileExtention = "avi",
                Duration = 160,
                Content = new byte[200]
            });

            this.db.Add(new MediaEntity
            {
                Title = "Lord of the Rings - The Two Towers",
                FileExtention = "avi",
                Duration = 160,
                Content = new byte[200]
            });

            this.db.Add(new MediaEntity
            {
                Title = "Lord of the Rings - The Return of the King",
                FileExtention = "avi",
                Duration = 160,
                Content = new byte[200]
            });

            this.db.Add(new MediaEntity
            {
                Title = "Lord of the Rings - The Fellowship of the Ring",
                FileExtention = "mkv",
                Duration = 160,
                Content = new byte[200]
            });

            this.db.Add(new MediaEntity
            {
                Title = "The next three days",
                FileExtention = "mpeg",
                Duration = 160,
                Content = new byte[200]
            });

            this.db.Add(new MediaEntity
            {
                Title = "Red",
                FileExtention = "mp4",
                Duration = 160,
                Content = new byte[200]
            });
        }
    }
}
