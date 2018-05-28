namespace StateDemo
{
    public interface ICommands
    {
        void Delete();
        void Edit(string title, string description);
        void Print();
        void SetState(string state);
    }
}
