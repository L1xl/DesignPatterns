using System;
using System.Collections.Generic;
using System.Text;

namespace DecoratorPattern
{
    class ConcreteDecoratorA : Decorator
    {
        
        public override void Operation()
        {
            
            base.Operation();
            MethodA();
        }
        public void MethodA()
        {
            Console.WriteLine("method a is used");
        }
    }
}
