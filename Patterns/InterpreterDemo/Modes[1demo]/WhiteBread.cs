namespace InterpreterDemo.Modes_1demo_
{
    public class WhiteBread : IBread
    {
        public void Interpret(Context context)
        {
            context.Output += "WhiteBread";
        }
    }

}
