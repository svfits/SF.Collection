using SF.Collection;
using System;
using System.Collections.Generic;
using System.Text;

namespace SF.UML
{
    class ChildrenClass1 : BaseClass, IBaseClass
    {
        public ChildrenClass1(int myInt)
        {
            MyProperty4 = myInt;
        }

        private int myVar;

        public int MyProperty5
        {
            get { return myVar; }
            set { myVar = value; }
        }

        public int MyProperty4 { get; private set; }
    }
}
