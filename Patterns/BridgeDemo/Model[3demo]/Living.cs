using System;

namespace BridgeDemo.Model_3demo_
{
    public abstract class Living
    {
        public IPresenter presenter { get; set; }
        public int Age { get; set; }
        public string Name { get; set; }
        public abstract void Talk();
    }

    public interface IPresenter
    {
        void Introduce(int age, string name);
    }

    public class Cat : Living
    {
        public override void Talk()
        {
            presenter.Introduce(Age, Name);
        }
    }

    public class Tiger : IPresenter
    {
        public void Introduce(int age, string name)
        {
            Console.WriteLine($"I am a big bad {this.GetType().Name} with name:{name} and years{age}");
        }
    }

    public class Zebra : IPresenter
    {
        public void Introduce(int age, string name)
        {
            Console.WriteLine($"I like to eat grass {this.GetType().Name} with name:{name} and years{age}");
        }
    }
}
