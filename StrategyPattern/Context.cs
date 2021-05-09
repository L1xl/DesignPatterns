using System;
using System.Collections.Generic;
using System.Text;

namespace StrategyPattern
{
    class Context
    {
        Strategy strategy;
        public Context(Strategy strategy)
        {
            this.strategy = strategy;
        }
        public void ContextInterface()
        {
            strategy.AlgorithmInterface();
        }
    }
}
