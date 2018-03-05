using System.Collections.Generic;

namespace InterpreterDemo.Modes_1demo_
{
    public class CondimentList : IExpression
    {
        private readonly List<ICondiment> condiments;
        public CondimentList(List<ICondiment> condiments)
        {
            this.condiments = condiments;
        }
        public void Interpret(Context context)
        {
            foreach (var condiment in this.condiments)
            {
                condiment.Interpret(context);
            }
        }
    }
}
