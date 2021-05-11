using System;
using System.Collections.Generic;
using System.Text;

namespace ProxyPattern
{
    class RealSubject : Subject
    {
        public void Request()
        {
            Console.WriteLine("request 1");
        }

        public void Request2()
        {
            Console.WriteLine("request 2");
        }
    }
}
