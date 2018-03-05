using InterpreterDemo.Models_2demo_;
using InterpreterDemo.Modes_1demo_;
using System;
using System.Collections;
using System.Collections.Generic;

namespace InterpreterDemo
{
    public class Interpreter
    {
        public static void FirstDemo()
        {
            var sandwitch = new Sandwitch(new WhiteBread(),
              new CondimentList(new List<ICondiment> { new MayoCondiment(), new KetchupCondiment() }),
              new IngredientList(new List<IIngredient> { new TomatoIngredient(), new Cucumber() }),
              new CondimentList(new List<ICondiment> { new MustardCondiment() }),
              new BrownBread()
              );

            sandwitch.Interpret(new Context());
            Console.ReadLine();
        }

        public static void SecondDemo()
        {
            Contextt context = new Contextt();

            // Usually a tree 

            ArrayList list = new ArrayList();

            // Populate 'abstract syntax tree' 

            list.Add(new TerminalExpression());
            list.Add(new NonterminalExpression());
            list.Add(new TerminalExpression());
            list.Add(new TerminalExpression());

            // Interpret

            foreach (AbstractExpression exp in list)
            {
                exp.Interpret(context);
            }

            // Wait for user

            Console.ReadKey();
        }
    }
}