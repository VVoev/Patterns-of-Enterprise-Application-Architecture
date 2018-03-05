namespace InterpreterDemo.Modes_1demo_
{
    public class KetchupCondiment : ICondiment
    {
        public void Interpret(Context context)
        {
            context.Output += "Ketchup";
        }
    }

}
