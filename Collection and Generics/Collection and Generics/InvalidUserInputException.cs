using System;
using System.Collections.Generic;
using System.Text;

namespace Collection_and_Generics
{
    class InvalidUserInputException:Exception
    {
        public InvalidUserInputException(string message):base(message)
        {

        }
    }
}
