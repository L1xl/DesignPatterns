using System;
using System.Collections.Generic;
using System.Text;

namespace SimpleFactoryPattarn
{
    class FactoryC:Factory
    {
        public override void Operate()
        {
            Console.WriteLine("method c is operated");
        }
    }
}
