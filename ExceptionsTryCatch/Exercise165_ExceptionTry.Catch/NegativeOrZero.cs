using System;
using System.Collections.Generic;
using System.Text;

namespace Exercise165_ExceptionTry.Catch
{
    class NegativeOrZero : Exception
    {
        public NegativeOrZero()
            : base() { }
    }
}
