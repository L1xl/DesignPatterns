using System;
using System.Collections.Generic;
using System.Text;

namespace SimpleFactoryPattarn
{
    class FactoryB:Factory
    {
        public override void Operate()
        {
            Console.WriteLine("method b is operated");
        }
    }
}
