using System;
using System.Collections.Generic;
using System.Text;
using Board.Contracts;
using Common;
using Figures;
using Players.Contracts;

namespace Engine.Initializations
{
    public class StandartGameInitializationStrategy : IGameInitializationStrategy
    {
        private const int NumberOfPlayers = 2;
        private const int BoardTotalRowsAndCols = 8;
        private IList<Type> figureTypes;

        public StandartGameInitializationStrategy()
        {
            this.figureTypes = new List<Type>
            {
                typeof(Rook),
                typeof(Knight),
                typeof(Bishop),
                typeof(Queen),
                typeof(King),
                typeof(Bishop),
                typeof(Knight),
                typeof(Rook),
            };
        }
        public void Initialize(IList<IPlayer> players, IBoard board)
        {
            this.ValidateStrategy(players, board);
            var firstPlayer = players[0];
            var secondPlayer = players[1];
          
            this.AddPawnsToBoardRow(firstPlayer, board, 7);
            this.AddArmyToBoardRow(firstPlayer, board, 8);

            this.AddPawnsToBoardRow(secondPlayer, board, 2);
            this.AddArmyToBoardRow(secondPlayer, board, 1);
        }

        private void AddArmyToBoardRow(IPlayer player,IBoard board,int chessRow)
        {
            for (int i = 0; i < BoardTotalRowsAndCols; i++)
            {
                var figureType = this.figureTypes[i];
                var figureInstance = (IFigure)Activator.CreateInstance(figureType, player.Color);
                player.AddFigure(figureInstance);
                var position = new Position(chessRow, (char)(i + 'a'));
                board.AddFigure(figureInstance, position);
            }
        }
        private void AddPawnsToBoardRow(IPlayer player, IBoard board,int chessRow)
        {
            for (int i = 0; i < BoardTotalRowsAndCols; i++)
            {
                var pawn = new Pawn(player.Color);
                var position = new Position(chessRow, (char)(i + 'a'));
                player.AddFigure(pawn);
                board.AddFigure(pawn, position);
            }
        }
        private void ValidateStrategy(ICollection<IPlayer> players, IBoard board)
        {
            if (players.Count != NumberOfPlayers)
            {
                throw new InvalidOperationException("StandartGameInitializationStrategy must have 2 players");
            }

            if (board.TotalCols != BoardTotalRowsAndCols || board.TotalRows != BoardTotalRowsAndCols)
            {
                throw new InvalidOperationException("StandartGameInitializationStrategy must have a board 8x8");
            }
        }
    }
}
