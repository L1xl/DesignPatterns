using System;
using System.Collections.Generic;
using System.Text;

namespace FactoryMethodPattern
{
    class FactoryB : IFactory
    {
        public Product CreateProduct()
        {
            return new ProductB();
        }
    }
}
