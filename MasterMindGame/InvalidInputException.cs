using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
