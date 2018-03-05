namespace InterpreterDemo.Modes_1demo_
{
    public class Cucumber : IIngredient
    {
        public void Interpret(Context context)
        {
            context.Output += "Cucumber";
        }
    }
}
