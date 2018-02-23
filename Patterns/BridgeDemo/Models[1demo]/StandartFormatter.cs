namespace BridgeDemo.Models_1demo_
{
    public class StandartFormatter : IFormater
    {
        public string Format(string key, string value)
        {
            return string.Format($"{key} : {value}");
        }
    }
}
