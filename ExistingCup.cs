using System;
using System.Collections.Generic;
using System.Text;

namespace _19_Exceptions
{
    class ExistingCup : Exception
    {
        public ExistingCup (string message): base(message)
        {
        }
    }
}
