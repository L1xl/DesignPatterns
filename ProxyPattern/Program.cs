using System;

namespace ProxyPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            Proxy proxy = new Proxy();
            proxy.Request();
            proxy.Request2();
            Console.ReadLine();
        }
    }
}
