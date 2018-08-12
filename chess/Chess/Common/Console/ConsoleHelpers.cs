using System;
using System.Collections.Generic;
using System.Text;

namespace Common.ConsoleHelpers
{
    public static class ConsoleHelpers
    {
        public static ConsoleColor ToConsoleColor(this ChessColor chessColor)
        {
            switch (chessColor)
            {
                case ChessColor.Black:
                    return ConsoleColor.Black;
                case ChessColor.White:
                    return ConsoleColor.White;
                default:
                    throw new InvalidOperationException("Invalid ChessColor");
            }
        }

        public static void SetCursorAtCenter(int lenghtOfMessage)
        {
            int centerRow = Console.WindowHeight / 2;
            int centerCol = Console.WindowWidth / 2 - lenghtOfMessage / 2;
            Console.SetCursorPosition(centerCol, centerRow);
        }

        public static void PrintFigure(IFigure figure,ConsoleColor backgroundColor,ConsoleColor figureColor)
        {
            if (figure == null)
            {
                PrintEmptySquare(backgroundColor);
            }
        }

        public static void PrintEmptySquare(ConsoleColor backgroundColor)
        {

        }
    }
}
