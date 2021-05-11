using System;
using System.Collections.Generic;
using System.Text;

namespace ProxyPattern
{
    class Proxy : Subject
    {
        RealSubject realSubject;
        public void Request()
        {
            if(realSubject==null)
            {
                realSubject = new RealSubject();
            }
            realSubject.Request();
        }

        public void Request2()
        {
            if (realSubject == null)
            {
                realSubject = new RealSubject();
            }
            realSubject.Request2();
        }
    }
}
