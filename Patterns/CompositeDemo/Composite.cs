using CompositeDemo.Models_1demo_;
using CompositeDemo.Models_2demo_;
using System;

namespace CompositeDemo
{
    public class Composite
    {
        public static void InitializeFirstDemo()
        {
            int goldForKill = 2326;
            var vlado = new Person() { Name = "Vlado" };
            var bobi = new Person() { Name = "Bobi" };
            var kafeto = new Person() { Name = "Stefan" };
            var paco = new Person() { Name = "Cvetozar" };
            var petko = new Person() { Name = "Petko" };

            var bobs1 = new Person() { Name = "Old Bob1" };
            var bobs2 = new Person() { Name = "Old Bob2" };
            var bobs3 = new Person() { Name = "Old Bob3" };

            var bobs = new Group { Members = { bobs1, bobs2, bobs3 } };

            var developers = new Group { Name = "Developers", Members = { vlado, kafeto, petko,bobs } };

            var parties = new Group { Members = { developers, paco, bobi } };
            parties.Gold += goldForKill;
            parties.Stats();
            Console.ReadKey();
        }

       
        public static void InitializeSecondDemo()
        {
            var root = new CompositeX("root");
            root.Add(new Leaf("Leaf A"));
            root.Add(new Leaf("Leaf B"));

            CompositeX comp = new CompositeX("Composite X");
            comp.Add(new Leaf("Leaf XA"));
            comp.Add(new Leaf("Leaf XB"));

            root.Add(comp);
            root.Add(new Leaf("Leaf C"));

            // Add and remove a leaf

            Leaf leaf = new Leaf("Leaf D");
            root.Add(leaf);
            //root.Remove(leaf);

            // Recursively display tree

            root.Display(0);

            // Wait for user

        }

        public static void InitializeThirdDemo()
        {
            var player = new Player("Ivan");
            var compositePlayer = new CompositePlayer("Composite Player");
            var enemy = new Player("Enemy");

            compositePlayer.Add(player);
            compositePlayer.Add(enemy);
            player.Attack(enemy);
            compositePlayer.ShowMeWhoYouAre();
        }

    }
}