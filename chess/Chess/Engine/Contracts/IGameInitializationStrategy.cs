using Board.Contracts;
using Players.Contracts;
using System;
using System.Collections.Generic;
using System.Text;

namespace Engine.Initializations
{
    public interface IGameInitializationStrategy
    {
        void Initialize(IList<IPlayer> players, IBoard board);
    }
}
