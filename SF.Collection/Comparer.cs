using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Text;

namespace SF.Collection
{
    public class Comparer : IComparer<User>
    {
        public int Compare([AllowNull] User x, [AllowNull] User y)
        {
            if (x.id > y.id)
            {
                return 1;
            }
            else if (x.id == y.id)
            {
                return 0;
            }

            return -1;
        }
    }
}
