using System;

namespace MasterMindGame
{
    class CodeEngine
    {
        public int CookTheSecretCode()
        {
            int code=0;
            try
            {
                Random random = new Random();
                code = random.Next(1000, 9999);
                
            }
            catch (Exception ex)
            {
                throw ex;
            }

           
            
            return code;
        }
    }
}
