using System;
using System.Collections.Generic;
using System.Text;

namespace Playground
{
    class TuningLevelOne : ITuning
    {
        public void LevelUp(Car car)
        {
            car.Bhp += 30;
        }
    }

    class TuningLeveTwo : ITuning
    {
        public void LevelUp(Car car)
        {
            car.Bhp += 130;
        }
    }

    class NoTuning : ITuning
    {
        public void LevelUp(Car car)
        {
            car.Bhp = car.Bhp;
        }
    }
}
