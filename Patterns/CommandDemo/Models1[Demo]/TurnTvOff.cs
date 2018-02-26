namespace CommandDemo.Models1_Demo_
{
    public class TurnTvOff : ICommand
    {
        private readonly IElectronicDevice device;

        public TurnTvOff(IElectronicDevice device)
        {
            this.device = device;
        }

        public void Execute()
        {
            device.Off();
        }

        public void Undo()
        {
            device.On();
        }
    }

}
