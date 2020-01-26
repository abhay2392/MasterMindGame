using System;

namespace MasterMindGame
{
    class InvalidInputException:Exception
    {
        public InvalidInputException()
        {
            
        }

        public InvalidInputException(string message)
            : base(String.Format("{0}", message))
    {
            //log your error here.
    }
    }
}
