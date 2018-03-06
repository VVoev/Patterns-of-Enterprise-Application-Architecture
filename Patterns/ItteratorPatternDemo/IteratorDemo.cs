using ItteratorPatternDemo.Models_1demo_;
using ItteratorPatternDemo.Modesl_2demo_;
using System;

namespace ItteratorPatternDemo
{
    public class IteratorDemo
    {
        public static void FirstDemo()
        {
            ConcreteAggregate a = new ConcreteAggregate();
            a[0] = "Item A";
            a[1] = "Item B";
            a[2] = "Item C";
            a[3] = "Item D";

            // Create Iterator and provide aggregate

            Iterator i = a.CreateIterator();

            Console.WriteLine("Iterating over collection:");

            object item = i.GetFirst();
            while (item != null)
            {
                Console.WriteLine(item);
                item = i.GetNext();
            }

            // Wait for user

            Console.ReadKey();
        }

        public static void SecondDemo()
        {
            Collection collection = new Collection();
            collection[0] = new Item("Item 0");
            collection[1] = new Item("Item 1");
            collection[2] = new Item("Item 2");
            collection[3] = new Item("Item 3");
            collection[4] = new Item("Item 4");
            collection[5] = new Item("Item 5");
            collection[6] = new Item("Item 6");
            collection[7] = new Item("Item 7");
            collection[8] = new Item("Item 8");

            // Create iterator

            Itterator iterator = collection.CreateIterator();

            // Skip every other item

            iterator.Step = 2;

            Console.WriteLine("Iterating over collection:");

            for (Item item = iterator.First();
                !iterator.IsDone; item = iterator.Next())
            {
                Console.WriteLine(item.Name);
            }

            // Wait for user

            Console.ReadKey();
        }
    }
}