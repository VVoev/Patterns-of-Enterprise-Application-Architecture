using System;
using System.Collections.Generic;
using System.Text;

namespace Common
{
    public struct Position
    {
        public Position(int row, char col)
            : this()
        {
            this.Row = row;
            this.Col = col;
        }
        public int Row { get; set; }
        public char Col { get; set; }
    }
}
