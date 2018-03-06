namespace ItteratorPatternDemo.Models_1demo_
{
    public class ConcreteIterator : Iterator
    {
        private ConcreteAggregate aggregate;
        private int current;

        public ConcreteIterator(ConcreteAggregate aggregate)
        {
            this.aggregate = aggregate;
        }

        public override dynamic CurrentItem()
        {
            return aggregate[current];
        }

        public override dynamic GetFirst()
        {
            return aggregate[0];
        }

        public override dynamic GetNext()
        {
            object buffer = null;
            var result = current < aggregate.Count - 1 ? aggregate[++current] : buffer;
            return result;
        }

        public override bool IsDone()
        {
            return current >= aggregate.Count;
        }
    }

}
