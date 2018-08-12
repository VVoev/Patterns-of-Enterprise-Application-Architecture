using System;
using System.Collections.Generic;
using System.Text;
using Common;

namespace Figures
{
    class Pawn : IFigure
    {
        public Pawn(ChessColor color)
        {
            this.Color = color;
        }

        public ChessColor Color { get; private set; }
    }
}
