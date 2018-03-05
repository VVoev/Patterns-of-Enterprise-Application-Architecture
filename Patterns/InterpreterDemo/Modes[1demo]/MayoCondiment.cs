namespace InterpreterDemo.Modes_1demo_
{
    public class MayoCondiment : ICondiment
    {
        public void Interpret(Context context)
        {
            context.Output += "Mayo";
        }
    }

}
