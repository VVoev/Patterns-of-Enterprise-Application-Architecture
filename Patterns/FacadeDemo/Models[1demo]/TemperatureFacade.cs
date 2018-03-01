namespace FacadeDemo
{
    public class TemperatureFacade
    {
        private readonly WeatherService weatherService;
        private readonly GeoLookUpService geoLookUpService;
        private readonly EnglishMetricConverterService englishMetricConverterService;

        public TemperatureFacade()
            :this(new WeatherService(),new GeoLookUpService(),new EnglishMetricConverterService())
        {
            
        }

        private TemperatureFacade(WeatherService weatherService,GeoLookUpService geoLookUpService, EnglishMetricConverterService englishMetricConverter)
        {
            this.weatherService = weatherService;
            this.geoLookUpService = geoLookUpService;
            this.englishMetricConverterService = englishMetricConverter;
        }

        public LocalTemperature GetTemperature(string zipCode)
        {
            var cords = geoLookUpService.GetCordsForZipCode(zipCode);
            var city = geoLookUpService.GetCityForZipCode(zipCode);
            var state = geoLookUpService.GetStateForZipCode(zipCode);

            
            var farenheit = weatherService.GetTempFarenheit(cords.Latitude, cords.Longitude);
            var celsius = englishMetricConverterService.FarenheitToCelsius(farenheit);

            var localTemperature = new LocalTemperature()
            {
                Farenheit = farenheit,
                Celsius = celsius,
                City = city,
                State = state
            };

            return localTemperature;
        }
    }

    public class LocalTemperature
    {
        public LocalTemperature()
        {
        }

        public double Celsius { get; set; }
        public string City { get; set; }
        public double Farenheit { get; set; }
        public object State { get; set; }
    }
}