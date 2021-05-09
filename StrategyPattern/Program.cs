using System;

namespace StrategyPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            Context context;
            context= new Context(new StrategyA());
            context.ContextInterface();

            context = new Context(new StrategyB());
            context.ContextInterface();

            Console.ReadLine();
        }
    }
}
