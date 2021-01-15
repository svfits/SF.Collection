using SF.Collection;
using System;
using System.Collections.Generic;
using System.Text;

namespace SF.UML
{
    class Class3 : BaseClass
    {
        public Class2 Class2;

        public Class3()
        {
            Class2 Class2 = new Class2();
        }
    }
}
