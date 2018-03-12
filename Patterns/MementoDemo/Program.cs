using System;

namespace MementoDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            FirstDemo();

            SalesProspect s = new SalesProspect();
            s.Name = "Noel van Halen";
            s.Phone = "(412) 256-0990";
            s.Budget = 25000.0;

            // Store internal state

            ProspectMemory m = new ProspectMemory();
            m.Memento = s.SaveMemento();

            // Continue changing originator

            s.Name = "Leo Welch";
            s.Phone = "(310) 209-7111";
            s.Budget = 1000000.0;

            // Restore saved state

            s.RestoreMemento(m.Memento);

            // Wait for user

            Console.ReadKey();

        }

        class SalesProspect

        {
            private string _name;
            private string _phone;
            private double _budget;

            // Gets or sets name

            public string Name
            {
                get { return _name; }
                set

                {
                    _name = value;
                    Console.WriteLine("Name:  " + _name);
                }
            }

            // Gets or sets phone

            public string Phone
            {
                get { return _phone; }
                set

                {
                    _phone = value;
                    Console.WriteLine("Phone: " + _phone);
                }
            }

            // Gets or sets budget

            public double Budget
            {
                get { return _budget; }
                set

                {
                    _budget = value;
                    Console.WriteLine("Budget: " + _budget);
                }
            }

            // Stores memento

            public Memento SaveMemento()
            {
                Console.WriteLine("\nSaving state --\n");
                return new Memento(_name, _phone, _budget);
            }

            // Restores memento

            public void RestoreMemento(Memento memento)
            {
                Console.WriteLine("\nRestoring state --\n");
                this.Name = memento.Name;
                this.Phone = memento.Phone;
                this.Budget = memento.Budget;
            }
        }

        class Memento

        {
            private string _name;
            private string _phone;
            private double _budget;

            // Constructor

            public Memento(string name, string phone, double budget)
            {
                this._name = name;
                this._phone = phone;
                this._budget = budget;
            }

            // Gets or sets name

            public string Name
            {
                get { return _name; }
                set { _name = value; }
            }

            // Gets or set phone

            public string Phone
            {
                get { return _phone; }
                set { _phone = value; }
            }

            // Gets or sets budget

            public double Budget
            {
                get { return _budget; }
                set { _budget = value; }
            }
        }

        /// <summary>

        /// The 'Caretaker' class

        /// </summary>

        class ProspectMemory

        {
            private Memento _memento;

            // Property

            public Memento Memento
            {
                set { _memento = value; }
                get { return _memento; }
            }
        }

        private static void FirstDemo()
        {
            Originator o = new Originator();
            o.State = "On";

            // Store internal state

            Carataker c = new Carataker();
            c.Memento = o.CreateMemento();

            // Continue changing originator

            o.State = "Off";

            // Restore saved state

            o.SetMemento(c.Memento);

            // Wait for user

            Console.ReadKey();
        }
    }



    class Originator
    {
        private string state;

        public string State
        {
            get { return this.state; }
            set { this.state = value; Console.WriteLine($"State {state}"); }
        }

        public Memento1 CreateMemento()
        {
            return new Memento1(state);
        }

        public void SetMemento(Memento1 memento)
        {
            Console.WriteLine("Restoring state");
            State = memento.State;
        }
    }

    class Memento1
    {
        private string state;

        public Memento1(string state)
        {
            this.state = state;
        }

        public string State
        {
            get { return this.state; }
        }

    }

    class Carataker
    {
        private Memento1 memento;

        public Memento1 Memento
        {
            get
            {
                return this.memento;
            }
            set
            {
                this.memento = value;
            }
        }
    }
}
