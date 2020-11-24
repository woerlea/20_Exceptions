using System;
using System.Collections.Generic;
using System.Text;

namespace _19_Exceptions
{
    class WhiteColorException : Exception
    {
        public WhiteColorException (string message) : base(message)
        {

        }
    }
}
