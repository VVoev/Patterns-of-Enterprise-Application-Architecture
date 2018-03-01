using FacadePattern;
using System;

namespace FacadeDemo
{
    public class FacadeP
    {
        public static void FirstDemo()
        {
            const string zipCode = "6000";

            #region OLD API
            //GeoLookUpService geoLookUpService = new GeoLookUpService();
            //var city = geoLookUpService.GetCityForZipCode(zipCode);
            //var state = geoLookUpService.GetStateForZipCode(zipCode);
            //var cords = geoLookUpService.GetCordsForZipCode(zipCode);

            //var weatherService = new WeatherService();
            //var farenheit = weatherService.GetTempFarenheit(cords.Latitude, cords.Longitude);

            //var englishMetricConverterService = new EnglishMetricConverterService();
            //var celius = englishMetricConverterService.FarenheitToCelsius(farenheit);
            #endregion


            //FACADE
            TemperatureFacade temperatureFacade = new TemperatureFacade();
            var localTemperature = temperatureFacade.GetTemperature(zipCode);

            Console.WriteLine($"Current temperature is {localTemperature.Farenheit:f2}F in {localTemperature.Celsius:f2}C  {localTemperature.City}  {localTemperature.State}");
        }

        public static void SecondDemo()
        {
            var homeTheaterPro = HomeTheaterPro.CreateInstance();
            homeTheaterPro.InitHomeSystem();
            homeTheaterPro.DisplayAvailableMedia();
            homeTheaterPro.Next();
            homeTheaterPro.Next();
            homeTheaterPro.Previous();
            homeTheaterPro.Stop();
        }
    }
}