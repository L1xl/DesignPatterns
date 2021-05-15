using System;

namespace PrototypePattern
{
    class Program
    {
        static void Main(string[] args)
        {
            ConcretePrototype concrete1 = new ConcretePrototype("0");
            Console.WriteLine(concrete1.Id);

            ConcretePrototype clone1 =(ConcretePrototype) concrete1.Clone();
            Console.WriteLine(clone1.Id);

            Console.ReadLine();
        }
    }
}
