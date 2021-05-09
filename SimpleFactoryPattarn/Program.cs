using System;

namespace SimpleFactoryPattarn
{
    class Program
    {
        static void Main(string[] args)
        {
            SimpleFactory sFactory = new SimpleFactory();
            Factory factory = new Factory();
            factory = sFactory.createFactory("A");
            factory.Operate();
            Console.ReadLine();
        }
    }
}
