using System;
using System.Collections.Generic;
using System.Text;

namespace FactoryMethodPattern
{
    class FactoryA : IFactory
    {
        public Product CreateProduct()
        {
            return new ProductA();
        }
    }
}
