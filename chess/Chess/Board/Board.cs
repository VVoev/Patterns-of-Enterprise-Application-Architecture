using Common;
using Figures;
using System;
using System.Collections.Generic;
using System.Text;

namespace Board
{
    class Board
    {
        private readonly IFigure[,] board;

        public Board(int rows = GlobalConstants.STANDARTGAMETOTALBOARDROW, int cols = GlobalConstants.STANDARTGAMETOTALBOARDCOL)
        {
            this.TotalRows = rows;
            this.TotalCols = cols;
            this.board = new IFigure[rows, cols];
        }

        public int TotalRows { get; set; }

        public int TotalCols { get; set; }

        public void AddFigure(IFigure figure, Position position)
        {
            OBjectValidator.CheckIfOBjectIsNull(figure, GlobalErrorMessages.NULLFIGUREMESAGE);
            this.CheckIfPositionIsValid(position);

            int arrRow = this.GetArrayRow(position.Row);
            int arrCol = this.GetArrayCol(position.Col);
            this.board[arrRow, arrCol] = figure;
        }

        public void RemoveFigure(Position position)
        {
            this.CheckIfPositionIsValid(position);

            int arrRow = this.GetArrayRow(position.Row);
            int arrCol = this.GetArrayCol(position.Col);
            this.board[arrRow, arrCol] = null ;
        }

        private int GetArrayRow(int chessRow)
        {
            return this.TotalRows - chessRow;
        }

        private int GetArrayCol(char chessCol)
        {
            return chessCol - 'a';
        }

        private void CheckIfPositionIsValid(Position position)
        {
            if(position.Row < GlobalConstants.MIN_ROWSVALUE_BOARD || position.Row > GlobalConstants.MAX_ROWSVALUE_BOARD)
            {
                throw new IndexOutOfRangeException("Selected row is out of board");
            }
            if(position.Col < GlobalConstants.MIN_COLSVALUE_BOARD || position.Col > GlobalConstants.MAX_COLSVALUE_BOARD)
            {
                throw new IndexOutOfRangeException("Selected col is out of board");
            }
        }

    }
}
