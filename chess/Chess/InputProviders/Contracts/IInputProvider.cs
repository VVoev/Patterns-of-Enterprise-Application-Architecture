using Players.Contracts;
using System;
using System.Collections.Generic;
using System.Text;

namespace InputProviders.Contracts
{
    public interface IInputProvider
    {
        IList<IPlayer> GetPlayers(int numberOfPlayers);
    }
}
