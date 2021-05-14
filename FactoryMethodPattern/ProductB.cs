using System;
using System.Collections.Generic;
using System.Text;

namespace FactoryMethodPattern
{
    class ProductB : Product
    {
        public override void Function()
        {
            Console.WriteLine("Product B's function");
        }
    }
}
