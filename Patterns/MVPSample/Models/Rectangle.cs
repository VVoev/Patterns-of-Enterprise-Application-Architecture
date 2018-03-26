namespace MVPSample.Models
{
    public class Rectangle
    {
        public double Width { get; set; }

        public double Height { get; set; }

        public double CalculateSurface()
        {
            return Width * Height;
        }
    }
}
