namespace ItteratorPatternDemo.Models_1demo_
{
    public abstract class Iterator
    {
        public abstract dynamic GetFirst();
        public abstract dynamic GetNext();
        public abstract dynamic CurrentItem();
        public abstract bool IsDone();
    }

}
