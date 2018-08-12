using Board.Contracts;
using System;
using System.Collections.Generic;
using System.Text;

namespace UI.Contracts
{
    public interface IRenderer
    {
        void RenderBoard(IBoard board);

        void RenderMainMenu();
    }
}
