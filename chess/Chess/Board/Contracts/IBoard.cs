using Common;
using Figures;
using System;
using System.Collections.Generic;
using System.Text;

namespace Board.Contracts
{
    public interface IBoard
    {
        int TotalRows { get; }
        int TotalCols { get; }
        void AddFigure(IFigure figure, Position position);
        void RemoveFigure(Position position);
        IFigure GetFigureAtPosition(Position position);
    }
}
