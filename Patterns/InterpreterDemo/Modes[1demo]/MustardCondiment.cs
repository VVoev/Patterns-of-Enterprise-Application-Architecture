namespace InterpreterDemo.Modes_1demo_
{
    public class MustardCondiment : ICondiment
    {
        public void Interpret(Context context)
        {
            context.Output += "Mustard";
        }
    }

}
