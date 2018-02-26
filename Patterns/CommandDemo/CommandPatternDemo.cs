using CommandDemo.Models1_Demo_;

namespace CommandDemo
{
    public static class CommandPatternDemo
    {
        public static void FirstDemo()
        {
            IElectronicDevice newDevice = TvRemote.getDevice();
            TurnTvOn onCommand = new TurnTvOn(newDevice);
            DeviceButton onPressed = new DeviceButton(onCommand);
            onPressed.Press();
            TurnTvOff offcommand = new TurnTvOff(newDevice);
            onPressed = new DeviceButton(offcommand);
            onPressed.Press();


            TurnTvUp upcommand = new TurnTvUp(newDevice);
            onPressed = new DeviceButton(upcommand);
            onPressed.Press();
            onPressed.Press();
            onPressed.Press();

        }
    }
}