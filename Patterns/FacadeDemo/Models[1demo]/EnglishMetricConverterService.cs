namespace FacadeDemo
{
    public class EnglishMetricConverterService
    {
        public EnglishMetricConverterService()
        {
        }

        public double FarenheitToCelsius(double farenheit)
        {
            var celsius =  (farenheit - 32) * 5 / 9;
            return celsius;
        }
    }
}