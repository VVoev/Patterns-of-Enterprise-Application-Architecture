using System;

namespace InterpreterDemo.Models_2demo_
{
    /// <summary>

    /// The 'AbstractExpression' abstract class

    /// </summary>

    abstract class AbstractExpression

    {
        public abstract void Interpret(Contextt context);
    }

    /// <summary>

    /// The 'TerminalExpression' class

    /// </summary>

    class TerminalExpression : AbstractExpression

    {
        public override void Interpret(Contextt context)
        {
            Console.WriteLine("Called Terminal.Interpret()");
        }
    }

    /// <summary>

    /// The 'NonterminalExpression' class

    /// </summary>

    class NonterminalExpression : AbstractExpression

    {
        public override void Interpret(Contextt context)
        {
            Console.WriteLine("Called Nonterminal.Interpret()");
        }
    }

    /// <summary>

    /// The 'Context' class

    /// </summary>

    class Contextt

    {
    }
}
