using DecoratorDemo.Models_1demo_;
using System;
using System.Collections.Generic;

namespace DecoratorDemo
{
    public static class Decorator
    {
        public static void FirstDemo()
        {

            Pizza small = new SmallPizza();
            Pizza medium = new MediumPizza();
            Pizza large = new LargePizza();

            var pizzas = new List<Pizza> { small, medium, large };


            Console.WriteLine($"Normal Pizza Prices");
            PrintPizzaPrices(pizzas);
            pizzas.Clear();

            Console.WriteLine($"Pizza Prices with Cheese");
            small = new Cheese(small);
            medium = new Cheese(medium);
            large = new Cheese(large);
            pizzas = new List<Pizza> { small, medium, large };
            PrintPizzaPrices(pizzas);
            pizzas.Clear();

            Console.WriteLine($"Pizza Prices with Cheese && Peperonni");

            small = new Pepperenni(small);
            medium = new Pepperenni(medium);
            large = new Pepperenni(large);
            pizzas = new List<Pizza> { small, medium, large };
            PrintPizzaPrices(pizzas);

            small = new CreamySauce(small);
            medium = new CreamySauce(medium);
            large = new CreamySauce(large);

            pizzas = new List<Pizza> { small, medium, large };
            PrintPizzaPrices(pizzas);

            small = new ChiliSauce(small);
            pizzas = new List<Pizza> { small};
            PrintPizzaPrices(pizzas);




        }

        private static void PrintPizzaPrices(List<Pizza> pizzas)
        {
            foreach (var pizza in pizzas)
            {
                Console.WriteLine($"{pizza.GetDescription()} with price {pizza.CalculateCost():f2}");
            }
        }
    }
}