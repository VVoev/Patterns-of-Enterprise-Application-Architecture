using System.Collections.Generic;
using Board.Contracts;
using Common;
using Engine.Contracts;
using Engine.Initializations;
using InputProviders.Contracts;
using Players;
using Players.Contracts;
using UI.Contracts;

namespace Engine
{
    public class StandartTwoPlayerEngine : IChessEngine
    {
        private readonly IEnumerable<IPlayer> players;
        private readonly IRenderer renderer;
        private readonly IInputProvider inputProvider;
        private readonly IBoard board;

        public StandartTwoPlayerEngine(IRenderer renderer,IInputProvider inputProvider)
        {
            this.renderer = renderer;
            this.inputProvider = inputProvider;
            this.board = new BoardProject.Board();
        }

        public IEnumerable<IPlayer> Players
        {
            get
            {
                return new List<IPlayer>(this.players);
            }
        }

        public void Initialize(IGameInitializationStrategy gameInitializationStrategy)
        {
            //TODO Remove and use inputProvider
            var players = new List<IPlayer>
            {
                new Player("Qnko",ChessColor.Black),
                new Player("Goshko",ChessColor.White)
            };
            //this.inputProvider.GetPlayers(GlobalConstants.STANDARTGAMENUMBEROFPLAYERS);
            gameInitializationStrategy.Initialize(players, this.board);
            this.renderer.RenderBoard(board);
        }


        public void Start()
        {
            throw new System.NotImplementedException();
        }

        public void WinningConditions()
        {
            throw new System.NotImplementedException();
        }
    }
}
