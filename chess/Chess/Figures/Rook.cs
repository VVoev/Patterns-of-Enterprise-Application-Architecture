using Common;
using Figures.Contracts;
using System;
using System.Collections.Generic;
using System.Text;

namespace Figures
{
    public class Rook : BaseFigure, IFigure
    {
        public Rook(ChessColor color)
            : base(color)
        {
        }
    }
}
