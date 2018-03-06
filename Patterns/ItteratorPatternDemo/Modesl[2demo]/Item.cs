using System.Collections;
using System.Linq;

namespace ItteratorPatternDemo.Modesl_2demo_
{
    public class Item
    {
        public string Name { get; set; }

        public Item(string name)
        {
            this.Name = name;
        }
    }
    public interface IAbstractCollection
    {

    }
    public class Collection : IAbstractCollection
    {
        private ArrayList items = new ArrayList();

        public Itterator CreateIterator()
        {
            return new Itterator(this);
        }

        public int Count
        {
            get
            {
                return this.items.Count;
            }
        }

        public object this[int index]
        {
            get { return this.items[index]; }
            set { this.items.Add(value); }
        }



    }
    interface IAbstractIterator

    {
        Item First();
        Item Next();
        bool IsDone { get; }
        Item CurrentItem { get; }
        int Step { get; set; }
    }
    public class Itterator : IAbstractIterator
    {
        private Collection collection;
        private int current;
        private int step = 1;

        public Itterator(Collection collection)
        {
            this.collection = collection;
        }
        public Item CurrentItem
        {
            get
            {
                return this.collection[current] as Item;
            }
        }

        public bool IsDone
        {
            get
            {
                return current >= collection.Count;
            }
        }

        public int Step
        {
            get
            {
                return step;
            }
            set
            {
                this.step = value;
            }
        }

        public Item First()
        {
            return collection[0] as Item;
        }

        public Item Next()
        {
            current += step;
            if (!IsDone)
                return collection[current] as Item;
            else

                return null;
        }
    }
}
