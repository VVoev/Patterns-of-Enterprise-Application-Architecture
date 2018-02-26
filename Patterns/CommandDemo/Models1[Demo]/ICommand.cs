namespace CommandDemo.Models1_Demo_
{
    public interface ICommand
    {
        void Execute();

        void Undo();
    }

}
