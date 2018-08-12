using System;
using System.Collections.Generic;
using System.Text;
using Common;

namespace Figures.Contracts
{
    public abstract class BaseFigure : IFigure
    {
        protected BaseFigure(ChessColor color)
        {
            this.Color = color;
        }
        public ChessColor Color { get; }
    }
}
