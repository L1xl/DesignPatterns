using System;
using System.Collections.Generic;
using System.Text;

namespace SimpleFactoryPattarn
{
    class Factory
    {
        public virtual void Operate()
        {
            Console.WriteLine("operate this method");
        }
    }
}
