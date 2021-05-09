using System;
using System.Collections.Generic;
using System.Text;

namespace StrategyPattern
{
    class StrategyA : Strategy
    {
        public override void AlgorithmInterface()
        {
            Console.WriteLine("Algorithm A is used");
        }
    }
}
