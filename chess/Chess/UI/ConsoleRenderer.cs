using System;
using System.Threading;
using Board.Contracts;
using Common;
using Common.ConsoleHelpers;
using UI.Contracts;

namespace UI
{
    public class ConsoleRenderer : IRenderer
    {
        private const string Logo = "Just Chess";
        private const int CharaktersPerRowPerFigure = 9;
        private const int CharaktersPerColPerFigure = 9;
        private const ConsoleColor DarkSquareConsoleColor = ConsoleColor.DarkGray;
        private const ConsoleColor WhiteSquareConsoleColor = ConsoleColor.Gray;

        public void RenderMainMenu()
        {
            ConsoleHelpers.SetCursorAtCenter(Logo.Length);

            //TODO :add main menu
            Thread.Sleep(1000);

            Console.WriteLine(Logo);
        }

        public void RenderBoard(IBoard board)
        {
            var startRowPrint = 2;//Console.WindowHeight / 2 - (board.TotalRows / 2) * CharaktersPerRowPerFigure;
            var startColPrint = 2;// Console.WindowWidth / 2 - (board.TotalCols / 2) * CharaktersPerColPerFigure;
            var currentRowPrint = startRowPrint;
            var currentColPrint = startColPrint;

            Console.BackgroundColor = ConsoleColor.White;
            var counter = 0;

            for (int top = 0; top < board.TotalCols; top++)
            {
                for (int left = 0; left < board.TotalRows; left++)
                {
                    currentColPrint = startColPrint + left * CharaktersPerColPerFigure;
                    currentRowPrint = startRowPrint + top * CharaktersPerRowPerFigure;
                    Console.SetCursorPosition(currentColPrint, currentRowPrint);
                    Console.Write(" ");

                    var backgroundcolor = Console.BackgroundColor = counter % 2 == 0 ? DarkSquareConsoleColor : WhiteSquareConsoleColor;
                    var position = Position.FromArrayCoordinates(top, left, board.TotalRows);
                    var figure = board.GetFigureAtPosition(position);
                    ConsoleHelpers.PrintFigure(null, backgroundcolor, figure.Color.ToConsoleColor());
                    for (int i = 0; i < CharaktersPerRowPerFigure; i++)
                    {
                        for (int j = 0; j < CharaktersPerColPerFigure; j++)
                        {
                            Console.SetCursorPosition(currentColPrint + j, currentRowPrint+i);
                            Console.Write(" ");
                        }
                    }
                    counter++;
                }
                counter++;
               
            }

            Console.ReadLine();


        }
    }
}
