namespace CommandDemo.Models1_Demo_
{
    public class DeviceButton
    {
        ICommand command;

        public DeviceButton(ICommand newCommand)
        {
            this.command = newCommand;
        }
        public void Press()
        {
            this.command.Execute();
        }

        void pressUndo()
        {
            this.command.Undo();
        }
    }

}
