using Common;
using Figures.Contracts;

namespace Figures
{
    public class Bishop : BaseFigure, IFigure
    {
        public Bishop(ChessColor color)
            : base(color)
        {
        }
    }
}
