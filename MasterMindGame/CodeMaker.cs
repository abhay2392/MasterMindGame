using System;

namespace MasterMindGame
{
    class CodeMaker
    {
        public delegate int codeGeneratorHandler();
        public int GenerateCode(codeGeneratorHandler codeGeneratorHandler)
        {
            return codeGeneratorHandler();
        }

        public string VerifyGussedCode(string guess, string code)
        {
            string massege = string.Empty;
            if (guess == code)
            {
                return massege = "BULL, BULL, BULL, BULL";
            }
            for (int i = 0; i < code.Length; i++)
            {
                for (int j = 0; j < code.Length; j++)
                {
                    if (code[i] == guess[j] && i == j && code[i]!='*')
                    {
                        massege += "BULL, ";
                        code = code.Remove(i, 1).Insert(i, "*");
                        guess = guess.Remove(i, 1).Insert(i, "*");

                    }
                    if (code[i] == guess[j] && i != j && code[i]!='*' && guess[j]!='*')
                    {
                        massege += "COW, ";
                        code = code.Remove(i, 1).Insert(i, "*");
                        guess = guess.Remove(j, 1).Insert(i, "*");


                    }
                }

            }
            if (String.IsNullOrEmpty(massege))
                return massege;
            return massege.Substring(0,massege.Length - 2);
        }
    }
}
