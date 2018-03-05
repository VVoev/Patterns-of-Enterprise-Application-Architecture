namespace InterpreterDemo.Modes_1demo_
{
    public class Sandwitch : IExpression
    {
        private readonly IBread topBread;
        private readonly CondimentList topcondimentList;
        private readonly IngredientList ingredientList;
        private readonly CondimentList bottomcondimentList;
        private readonly IBread bottomBread;

        public Sandwitch(IBread topbread, CondimentList topcondimentList, IngredientList ingredientList, CondimentList bottomcondimentList, IBread bottomBread)
        {
            this.topBread = topbread;
            this.topcondimentList = topcondimentList;
            this.ingredientList = ingredientList;
            this.bottomcondimentList = bottomcondimentList;
            this.bottomBread = bottomBread;
        }


        public void Interpret(Context context)
        {
            context.Output += "|";
            topBread.Interpret(context);
            context.Output += "|";

            context.Output += "|";
            topcondimentList.Interpret(context);
            context.Output += "|";


            context.Output += "|";
            ingredientList.Interpret(context);
            context.Output += "|";

            context.Output += "|";
            bottomcondimentList.Interpret(context);
            context.Output += "|";


            context.Output += "|";
            bottomBread.Interpret(context);
            context.Output += "|";


        }
    }

}
