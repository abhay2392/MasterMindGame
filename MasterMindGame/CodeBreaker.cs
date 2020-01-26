using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MasterMindGame
{
    class CodeBreaker
    {
        public string ValidateCode(string input)
        {
            
            try
            {
                if (input.Length == 4)
                {
                    
                    return input;
                }
                else
                {
                    //for error logging purpose
                    throw new InvalidInputException("I should guess the code in integer and of length 4");
                }
            }
            catch (InvalidInputException ex)
            {
                throw ex;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
            
            
            
       
    }
}
