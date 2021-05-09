using System;
using System.Collections.Generic;
using System.Text;

namespace StrategyPattern
{
    class StrategyB : Strategy
    {
        public override void AlgorithmInterface()
        {
            Console.WriteLine("Algorithm B is used");
        }
    }
}
