using System.Collections.Generic;

namespace InterpreterDemo.Modes_1demo_
{
    public class IngredientList : IExpression
    {
        private readonly List<IIngredient> ingredients;
        public IngredientList(List<IIngredient> ingredients)
        {
            this.ingredients = ingredients;
        }
        public void Interpret(Context context)
        {
            foreach (var ingredient in ingredients)
            {
                ingredient.Interpret(context);
            }
        }
    }
}
