using Common;
using Figures.Contracts;
using System;
using System.Collections.Generic;
using System.Text;

namespace Figures
{
    public class Queen : BaseFigure, IFigure
    {
        public Queen(ChessColor color)
            : base(color)
        {
        }
    }
}
