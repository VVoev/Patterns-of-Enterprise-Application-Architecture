using System;
using System.Collections.Generic;
using System.Text;

namespace BuildeDemo
{
    public class Sandwich
    {
        public BreadType breadType { get; set; }
        public bool isToasted { get; set; }
        public CheeseType cheeseType { get; set; }
        public MeatType meatType { get; set; }
        public bool hasMayo { get; set; }
        public bool hasMustard { get; set; }
        public List<string> vegatables { get; set; }

        public Sandwich()
        {

        }

        public void Display()
        {
            var result = ToString();
            Console.WriteLine(result);
        }

        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.AppendLine(string.Format($"BreadType :{breadType}"));
            sb.AppendLine(string.Format($"isToasted :{isToasted}"));
            sb.AppendLine(string.Format($"CheeseType :{cheeseType}"));
            sb.AppendLine(string.Format($"MeatType :{meatType}"));
            sb.AppendLine(string.Format($"hasMayo :{hasMayo}"));
            sb.AppendLine(string.Format($"hasMustard :{hasMustard}"));
            sb.AppendLine(string.Format($"vegatables :{string.Join(" ", vegatables)}"));
            var result = sb.ToString();
            return result;
        }
    }

    public enum MeatType
    {
        Turkey,
        Ham,
        Pork,
        Beef
    }

    public enum CheeseType
    {
        White,
        Yellow,
        Cheedar,
        Swiss
    }

    public enum BreadType
    {
        White,
        Wheat,
        Wholegrain
    }

}
