using System;
using System.Collections.Generic;
using System.Text;

namespace DecoratorPattern
{
    class ConcreteDecoratorB:Decorator
    {
        
        public override void Operation()
        {
            base.Operation();
            MethodB();
        }
        public void MethodB()
        {
            Console.WriteLine("method b is used");
        }
    }
}
