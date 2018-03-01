namespace FacadeDemo
{
    public class GeoLookUpService
    {
        public GeoLookUpService()
        {
        }

        public string GetCityForZipCode(string zipCode)
        {
            return "Varna";
        }

        public string GetStateForZipCode(string zipCode)
        {
            return "Burgaski Region";
        }

        public Cords GetCordsForZipCode(string zipCode)
        {
            return new FacadeDemo.Cords(20.4, 15.2);
        }
    }
}