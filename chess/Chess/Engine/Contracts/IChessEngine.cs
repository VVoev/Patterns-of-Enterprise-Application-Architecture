using Engine.Initializations;
using Players.Contracts;
using System.Collections.Generic;

namespace Engine.Contracts
{
    public interface IChessEngine
    {
        void Initialize(IGameInitializationStrategy gameInitializationStrategy);

        void Start();

        void WinningConditions();

        IEnumerable<IPlayer> Players { get; }
    }
}
