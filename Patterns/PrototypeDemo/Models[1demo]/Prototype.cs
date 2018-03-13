namespace PrototypeDemo.Models_1demo_
{
    abstract class Prototype

    {
        private string _id;

        // Constructor

        public Prototype(string id)
        {
            this._id = id;
        }

        // Gets id

        public string Id
        {
            get { return _id; }
        }

        public abstract Prototype Clone();
    }
    class ConcretePrototype1 : Prototype

    {
        // Constructor

        public ConcretePrototype1(string id)
          : base(id)
        {
        }

        // Returns a shallow copy

        public override Prototype Clone()
        {
            return (Prototype)this.MemberwiseClone();
        }
    }
    class ConcretePrototype2 : Prototype

    {
        // Constructor

        public ConcretePrototype2(string id)
          : base(id)
        {
        }

        // Returns a shallow copy

        public override Prototype Clone()
        {
            return (Prototype)this.MemberwiseClone();
        }
    }
}
