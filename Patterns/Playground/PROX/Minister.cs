using System;
using System.Collections.Generic;
using System.Text;

namespace Playground
{
    class Minister
    {
        public string Name { get; set; }
        private Satelite sat;

        public Minister(string name)
        {
            this.sat = new Satelite(name, 0);
            this.Name = name;
        }

        public void activate(string password)
        {
            sat.activateSatelite(password);
        }

        public void TrackPerson(Person person)
        {
            sat.trackPerson(person);
        }
    }
}
