using System;
using System.Collections.Generic;

namespace CompositeDemo.Models_2demo_
{
    public class CompositeX : Component
    {
        private List<Component> children;
        public CompositeX(string name) : base(name)
        {
            this.children = new List<Component>();
        }

        public override void Add(Component c)
        {
            children.Add(c);
        }

        public override void Display(int depthLevel)
        {
            Console.WriteLine(new String('-', depthLevel) + name);

            foreach (var component in children)
            {
                component.Display(depthLevel + 2);
            }
        }

        public override void Remove(Component c)
        {
            children.Remove(c);
        }
    }

}
