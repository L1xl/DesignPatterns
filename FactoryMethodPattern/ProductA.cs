using System;
using System.Collections.Generic;
using System.Text;

namespace FactoryMethodPattern
{
    class ProductA : Product
    {
        public override void Function()
        {
            Console.WriteLine("Product A's function");
        }
    }
}
