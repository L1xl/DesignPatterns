using System;
using System.Collections.Generic;
using System.Text;

namespace SimpleFactoryPattarn
{
    class SimpleFactory
    {
        public Factory createFactory(string type)
        {
            Factory factory = null;
            switch (type)
            {
                case "A":
                    factory = new FactoryA();
                    break;
                case "B":
                    factory = new FactoryB();
                    break;
                case "C":
                    factory = new FactoryC();
                    break;
            }
            return factory;
        }
    }
}
