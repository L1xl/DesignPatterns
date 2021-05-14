using System;
using System.Collections.Generic;
using System.Text;

namespace FactoryMethodPattern
{
    interface IFactory
    {
        Product CreateProduct();
    }
}
