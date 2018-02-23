using System.Linq;

namespace BridgeDemo.Models_1demo_
{
    public class ReverseFormatter : IFormater
    {
        public string Format(string key, string value)
        {
            return string.Format($"{key} : {new string(value.Reverse().ToArray())}");
        }
    }
}
