using System;
using System.Collections.Generic;
using System.Text;
using Common;
using Figures.Contracts;

namespace Figures
{
    public class Knight : BaseFigure,IFigure
    {
        public Knight(ChessColor color)
            :base(color)
        {
        }
    }
}
