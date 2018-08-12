using Common;
using Figures.Contracts;
using System;
using System.Collections.Generic;
using System.Text;

namespace Figures
{
    public class King : BaseFigure, IFigure
    {
        public King(ChessColor color)
            : base(color)
        {
        }
    }
}
