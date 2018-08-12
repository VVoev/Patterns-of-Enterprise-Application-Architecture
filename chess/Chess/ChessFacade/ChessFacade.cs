using Engine;
using Engine.Contracts;
using Engine.Initializations;
using InputProviders;
using InputProviders.Contracts;
using System;
using UI;
using UI.Contracts;

namespace ChessFacadee
{
    public static class ChessFacade
    {
        public static void Start()
        {
            IRenderer renderer = new ConsoleRenderer();
            renderer.RenderMainMenu();

            IInputProvider inputProvider = new ConsoleInputProvider();
            IChessEngine chessEngine = new StandartTwoPlayerEngine(renderer, inputProvider);

            IGameInitializationStrategy strategy = new StandartGameInitializationStrategy();
            chessEngine.Initialize(strategy);
            chessEngine.Start();

            Console.ReadLine();
        }
    }
}
