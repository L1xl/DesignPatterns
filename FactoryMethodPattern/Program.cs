using System;

namespace FactoryMethodPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            IFactory factory = new FactoryA();//需要产品B时更改类型即可
            //IFactory factory = new FactoryA();

            Product pA= factory.CreateProduct();

            pA.Function();

            Console.ReadLine();

        }
    }
}
