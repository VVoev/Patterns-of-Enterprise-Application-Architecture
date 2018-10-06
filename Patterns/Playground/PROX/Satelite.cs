using System;
using System.Collections.Generic;
using System.Text;

namespace Playground
{
    class Satelite
    {
        private string password = "Hello World";
        private bool isSateliteActivated = false;
        private List<Person> trackedpeople;

        public Satelite(string name, int peopleTracked)
        {
            this.Name = name;
            this.PeopleTracked = peopleTracked;
            this.trackedpeople = new List<Person>();
        }

        public int HowManyPeopleAreTracked => this.trackedpeople.Count;

        public void activateSatelite(string password)
        {
            if (password == this.password)
            {
                this.isSateliteActivated = !this.isSateliteActivated;
                Console.WriteLine("Satelite is working");
            }
            else
            {
                throw new Exception("Wrong Password");
            }
        }

        public Person trackPerson(Person person)
        {
            this.trackedpeople.Add(person);
            return person;
        }

        public void deactivateSatelite()
        {
            this.isSateliteActivated = !this.isSateliteActivated;
        }

        public string Name { get; }
        public int PeopleTracked { get; }
    }
}
