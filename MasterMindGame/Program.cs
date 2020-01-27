using System;

namespace MasterMindGame
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                CodeMaker codeMaker = new CodeMaker();
                CodeEngine codeEngine = new CodeEngine();
                CodeBreaker codeBreaker = new CodeBreaker();
                CodeMaker.codeGeneratorHandler codeGeneratorHandler = codeEngine.CookTheSecretCode;
                CodeMaker.codeVerificationHandler codeVerificationHandler = codeEngine.VerifyGuessedCode;
                int code = codeMaker.GenerateCode(codeGeneratorHandler);
                Console.WriteLine("Code Generated:");
                Console.WriteLine(code);
                Console.WriteLine("Enter The Guess Code:");                
                string guess=codeBreaker.ValidateCode(Console.ReadLine());
                Console.WriteLine(codeMaker.VerifyGuessedCode(codeVerificationHandler,code.ToString(),guess));
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            Console.Read();

        }
    }
}
