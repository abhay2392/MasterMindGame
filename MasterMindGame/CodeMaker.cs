using System;
namespace MasterMindGame
{
    class CodeMaker
    {
        public delegate int codeGeneratorHandler();
        public delegate string codeVerificationHandler(string code,string guess);
        public int GenerateCode(codeGeneratorHandler codeGeneratorHandler)
        {
            return codeGeneratorHandler();
        }
        public string VerifyGuessedCode(codeVerificationHandler codeVerificationHandler, string code, string guess)
        {
           return codeVerificationHandler(code,guess);
        }
        

      
    }
}
