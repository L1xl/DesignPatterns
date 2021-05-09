using System;
using System.Collections.Generic;
using System.Text;

namespace SimpleFactoryPattarn
{
    class FactoryA:Factory
    {
        public override void Operate()
        {
            Console.WriteLine("method a is operated");
        }
    }
}
