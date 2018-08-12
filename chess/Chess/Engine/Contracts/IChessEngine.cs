using System;
using System.Collections.Generic;
using System.Text;

namespace Engine.Contracts
{
    public interface IChessEngine
    {
        void Initialize();

        void Start();

        void WinningConditions();
    }
}
