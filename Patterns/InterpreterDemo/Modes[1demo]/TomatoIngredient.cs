namespace InterpreterDemo.Modes_1demo_
{
    public class TomatoIngredient : IIngredient
    {
        public void Interpret(Context context)
        {
            context.Output += "Tomato";
        }
    }
}
