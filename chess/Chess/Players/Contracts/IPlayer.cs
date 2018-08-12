using Common;
using Figures;

namespace Players.Contracts
{
    public interface IPlayer
    {
        string Name { get; }

        ChessColor Color { get; }

        void AddFigure(IFigure figure);

        void RemoveFigure(IFigure figure);

    }
}
