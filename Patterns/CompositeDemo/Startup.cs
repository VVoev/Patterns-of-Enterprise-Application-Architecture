using System;
using System.Collections.Generic;

namespace CompositeDemo
{
    class Startup
    {
        static void Main(string[] args)
        {
            Composite.InitializeFirstDemo();

            Composite.InitializeSecondDemo();

            Composite.InitializeThirdDemo();
        }
    }

    public interface IGameObject
    {
        string Name { get; }

        int AttackPts { get; }

        void Attack(IGameObject another);

        void Defence(IGameObject another);
    }

    public class Player : IGameObject
    {
        private int attackPts = 5;

        public Player(string name)
        {
            this.Name = name;
        }
        public int AttackPts { get { return this.attackPts; } }

        public string Name { get; }

        public void Attack(IGameObject another)
        {
            Console.WriteLine($"{this.Name} attack {another.Name}");
        }

        public void Defence(IGameObject another)
        {
            Console.WriteLine($"{this.Name} defence {another.Name}");
        }
    }

    public class CompositePlayer : IGameObject
    {
        private List<IGameObject> players;
        public CompositePlayer(string name)
        {
            this.Name = name;
            this.players = new List<IGameObject>();
        }
        public int AttackPts { get { return 0; } }

        public string Name { get; }

        public void Attack(IGameObject another)
        {
            Console.WriteLine("I cannot attack");
        }

        public void Defence(IGameObject another)
        {
            Console.WriteLine("I cannot defend");
        }

        public void Add(IGameObject gameobjecT)
        {
            this.players.Add(gameobjecT);
        }

        public void ShowMeWhoYouAre()
        {
            foreach (var player in this.players)
            {
                Console.WriteLine($"I am {player.Name} with attack {player.AttackPts}");
            }
        }
    }
}
