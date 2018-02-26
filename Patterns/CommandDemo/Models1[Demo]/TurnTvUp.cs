namespace CommandDemo.Models1_Demo_
{
    public class TurnTvUp : ICommand
    {
        private readonly IElectronicDevice device;

        public TurnTvUp(IElectronicDevice device)
        {
            this.device = device;
        }
        public void Execute()
        {
            device.VolumeUp();
        }

        public void Undo()
        {
            device.VolumeDown();
        }
    }

}
