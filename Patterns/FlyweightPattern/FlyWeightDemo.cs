using FlyweightPattern.Models_1demo_;
using FlyweightPattern.Models_2demo_;
using System;

namespace FlyweightPattern
{
    public class FlyWeightDemo
    {
        public static void FirstDemo()
        {
            int extrinsicstate = 22;

            FlyWeightFactory factory = new FlyWeightFactory();

            // Work with different flyweight instances

            FlyWeight fx = factory.GetFlyWeight("X");
            fx.Operation(--extrinsicstate);

            FlyWeight fy = factory.GetFlyWeight("Y");
            fy.Operation(--extrinsicstate);

            FlyWeight fz = factory.GetFlyWeight("Z");
            fz.Operation(--extrinsicstate);

            UnsharedConcreteFlyweight fu = new

              UnsharedConcreteFlyweight();

            fu.Operation(--extrinsicstate);

            // Wait for user

            Console.ReadKey();
        }

        public static void SecondDemo()
        {
            // Build a document with text

            string document = "AAZZBBZBA";
            char[] chars = document.ToCharArray();

            CharacterFactory factory = new CharacterFactory();

            // extrinsic state

            int pointSize = 10;

            // For each character use a flyweight object

            foreach (char c in chars)
            {
                pointSize++;
                Character character = factory.GetCharacter(c);
                character.Display(pointSize);
            }

            // Wait for user

            Console.ReadKey();
        }
    }
}