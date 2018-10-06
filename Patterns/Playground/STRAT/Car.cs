using System;
using System.Collections.Generic;
using System.Text;

namespace Playground
{
    public class Car : ITuning
    {

        private readonly ITuning tuning;

        public Car(ITuning tuning)
        {
            this.tuning = tuning;
        }

        public string Producer { get; }
        public int Bhp { get; set; }
        public string Model { get; }


        public Car(string producer, int bhp, string model,ITuning tuning)
        {
            this.Producer = producer;
            this.Bhp = bhp;
            this.Model = model;
            this.tuning = tuning;
        }

        public void LevelUp(Car car)
        {
            this.tuning.LevelUp(car);
        }

        public override string ToString()
        {
            return $"I am a {this.Model} with bhp:{this.Bhp}";
        }
    }
}
