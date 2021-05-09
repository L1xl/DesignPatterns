using System;

namespace DecoratorPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            ConcreteComponent cComponent = new ConcreteComponent();
            ConcreteDecoratorA cdA = new ConcreteDecoratorA();
            ConcreteDecoratorB cdB = new ConcreteDecoratorB();
            cdA.SetComponent(cComponent);
            cdB.SetComponent(cdA);
            cdB.Operation();

            Console.ReadLine();
        }
    }
}
