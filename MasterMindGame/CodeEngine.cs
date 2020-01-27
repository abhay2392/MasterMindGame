using System;
using System.Configuration;

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

        public string VerifyGuessedCode(string code, string guess)
        {
            string value1 = ConfigurationSettings.AppSettings["String1"];
            string value2 = ConfigurationSettings.AppSettings["String2"];
            string massege = string.Empty;
            if (guess == code)
            {
                return massege = value2 + ", " + value2 + ", " + value2 + ", " + value2;
            }
            for (int i = 0; i < code.Length; i++)
            {
                for (int j = 0; j < code.Length; j++)
                {
                    if (code[i] == guess[j] && i == j && code[i] != '*')
                    {
                        massege += value2 + ", ";
                        code = code.Remove(i, 1).Insert(i, "*");
                        guess = guess.Remove(i, 1).Insert(i, "*");

                    }
                    if (code[i] == guess[j] && i != j && code[i] != '*' && guess[j] != '*')
                    {
                        massege += value1 + ", ";
                        code = code.Remove(i, 1).Insert(i, "*");
                        guess = guess.Remove(j, 1).Insert(j, "*");

                    }
                }

            }
            if (String.IsNullOrEmpty(massege))
                return massege;
            return massege.Substring(0, massege.Length - 2);
        }
    }
}
