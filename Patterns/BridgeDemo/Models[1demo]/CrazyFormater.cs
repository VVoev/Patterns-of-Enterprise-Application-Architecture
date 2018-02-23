using System;
using System.Text;

namespace BridgeDemo.Models_1demo_
{
    public class CrazyFormater : IFormater
    {
        public string Format(string key, string value)
        {
            var sb = new StringBuilder();
            Random rnd = new Random();
            for (int i = 0; i < value.Length; i++)
            {
                int word = rnd.Next(0, value.Length);
                sb.Append(value[word]);
            }
            value = sb.ToString();
            return string.Format($"{key} {value}");
        }
    }
}
