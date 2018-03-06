using System.Collections;
using System.Linq;

namespace ItteratorPatternDemo.Models_1demo_
{
    public class ConcreteAggregate : Aggregate
    {
        private ArrayList items = new ArrayList();
        public override Iterator CreateIterator()
        {

            return new ConcreteIterator(this);
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
            get { return items[index]; }
            set { items.Insert(index, value); }
        }
    }

}
