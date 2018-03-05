namespace InterpreterDemo.Modes_1demo_
{
    public class BrownBread : IBread
    {
        public void Interpret(Context context)
        {
            context.Output += "BrownBread";
        }
    }

}
