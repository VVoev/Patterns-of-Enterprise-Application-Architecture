using System;
using System.Collections.Generic;

namespace Playground
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             * AdapterFacade.Launch();
             * AdapterFacade.LaunchSecond();
             * AdapterFacade.LaunchThird();
             * AdapterFacade.LaunchFourth();
             * AdapterFacade.LaunchFifth();
             */


            RemoteButton tv = new TVRemoteMute(new Tv(1, 200));
            RemoteButton tv2 = new TVRemotePause(new Tv(1, 200));
            RemoteButton dvd = new DvDremote(new DvdDevice(1, 200));

            tv.buttonFiveIsPressed();
            tv.buttonSixIsPressed();
            tv.buttonNineIsPressed();

            Console.WriteLine("Next");
            tv2.buttonFiveIsPressed();
            tv2.buttonSixIsPressed();
            tv2.buttonSixIsPressed();
            tv2.buttonSixIsPressed();
            tv2.buttonSixIsPressed();
            tv2.buttonNineIsPressed();
            tv2.deviceFeddback();



            dvd.buttonFiveIsPressed();
            dvd.buttonFiveIsPressed();
            dvd.buttonSixIsPressed();

            dvd.deviceFeddback();

        }
    }


    public abstract class EnterteimentDevice
    {
        public int deviceState;

        public int maxSettings;

        public int volumeLevel = 0;

        public abstract void buttonFiveIsPressed();
        public abstract void buttonSixIsPressed();
        public void deviceFeedback()
        {
            if(deviceState < maxSettings || deviceState > 0)
            {
                Console.WriteLine($"On {deviceState}");
            }
        }
        public void buttonSevenPressed()
        {
            volumeLevel++;
            Console.WriteLine($"Volume at:{volumeLevel}");
        }
        public void buttonEightPressed()
        {
            volumeLevel--;
            Console.WriteLine($"Volume at:{volumeLevel}");
        }
    }
    class Tv : EnterteimentDevice
    {

        public Tv(int newDeviceState,int newMaxSettings)
        {
            deviceState = newDeviceState;
            maxSettings = newMaxSettings;
        }
        public override void buttonFiveIsPressed()
        {
            Console.WriteLine("Channel Up");
            deviceState--;
        }

        public override void buttonSixIsPressed()
        {
            Console.WriteLine("Channel Down");
            deviceState++;

        }

    }
    class DvdDevice : EnterteimentDevice
    {

        public DvdDevice(int newState, int newMaxSettings)

        {
            this.deviceState = newState;
            this.maxSettings = newMaxSettings;
        }
        public override void buttonFiveIsPressed()
        {
            Console.WriteLine("Dvd go to a new chapter");
            this.deviceState++;
        }

        public override void buttonSixIsPressed()
        {
            Console.WriteLine("Dvd go to a prev chapter");
            this.deviceState--;
        }
    }

    public abstract class RemoteButton
    {
        private EnterteimentDevice device;

        public RemoteButton(EnterteimentDevice device)
        {
            this.device = device;
        }

        public  void buttonSixIsPressed()
        {
            device.buttonSixIsPressed();
        }

        public void buttonFiveIsPressed()
        {
            device.buttonFiveIsPressed();
        }

        public void deviceFeddback()
        {
            device.deviceFeedback();
        }

        public abstract void buttonNineIsPressed();
    }
    public class TVRemoteMute : RemoteButton
    {
        private EnterteimentDevice device;

        public TVRemoteMute(EnterteimentDevice device) : base(device)
        {
            this.device = device;
        }

        public override void buttonNineIsPressed()
        {
            Console.WriteLine("TV was muted");
        }

        public void MuteTv()
        {
            this.device.volumeLevel = 0;
        }
    }
    public class TVRemotePause : RemoteButton
    {
        private EnterteimentDevice device;

        public TVRemotePause(EnterteimentDevice device) : base(device)
        {
        }

        public override void buttonNineIsPressed()
        {
            Console.WriteLine("TV was paused");
        }

        public void MuteTv()
        {
            this.device.volumeLevel = 0;
        }
    }
    class DvDremote : RemoteButton
    {
        public DvDremote(EnterteimentDevice device) : base(device)
        {
        }

        public override void buttonNineIsPressed()
        {
            Console.WriteLine("You start the dvd");
        }
    }



}
