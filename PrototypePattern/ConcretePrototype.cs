using System;
using System.Collections.Generic;
using System.Text;

namespace PrototypePattern
{
    class ConcretePrototype : Prototype
    {
        public ConcretePrototype(string id):base(id)
        {
            
        }
        public override Prototype Clone()
        {
            return (Prototype)this.MemberwiseClone();
        }
    }
}
