namespace CommandDemo.Models1_Demo_
{
    public class TurnTvDown : ICommand
    {
        private readonly IElectronicDevice device;

        public TurnTvDown(IElectronicDevice device)
        {
            this.device = device;
        }
        public void Execute()
        {
            device.VolumeDown();
        }

        public void Undo()
        {
            device.VolumeUp();
        }
    }

}
