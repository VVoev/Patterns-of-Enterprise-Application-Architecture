using System;

namespace CompositeDemo.Models_2demo_
{
    public class Leaf : Component
    {
        public Leaf(string name) : base(name)
        {
        }

        public override void Add(Component c)
        {
            throw new NotImplementedException();
        }

        public override void Display(int depthLevel)
        {
            Console.WriteLine(new String('-', depthLevel) + name);
        }

        public override void Remove(Component c)
        {
            throw new NotImplementedException();
        }
    }
}
