using System;
using System.Collections.Generic;
using System.Text;

namespace _19_Exceptions
{
    class SameCupException : Exception
    {
        public SameCupException (string message ) : base(message)
        {

        }
    }
}
