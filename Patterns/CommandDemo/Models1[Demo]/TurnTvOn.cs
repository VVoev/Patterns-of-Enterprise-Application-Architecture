namespace CommandDemo.Models1_Demo_
{
    public class TurnTvOn : ICommand
    {
        private readonly IElectronicDevice device;

        public TurnTvOn(IElectronicDevice device)
        {
            this.device = device;
        }

        public void Execute()
        {
            device.On();
        }

        public void Undo()
        {
            device.Off();
        }
    }

}
