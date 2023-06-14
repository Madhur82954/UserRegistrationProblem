using System;
using System.Collections.Generic;
using System.Text;

namespace UserRegistrationProblem
{
    public class InvalidUserException:Exception
    {
        public InvalidUserException(string message) : base(message)
        {

        }
    }
}
