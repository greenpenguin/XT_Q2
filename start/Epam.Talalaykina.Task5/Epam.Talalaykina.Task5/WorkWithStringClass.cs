namespace Epam.Talalaykina.Task5
{
    public class WorkWithStringClass
    {
        public string CheckingOfBrackets(string str)
        {
            if (str.Length % 2 != 0)
            {
                return "It's incorrect bracket sequence";
            }
            else
            {
                int parensCounterOpen = 0;
                int parensCounterClose = 0;
                int squareBracketsCounterOpen = 0;
                int squareBracketsCounterClose = 0;
                int curlyBracesCounterOpen = 0;
                int curlyBracesCounterClose = 0;
                
                for (int i = 0; i < str.Length; i++)
                {
                    if (str[i] != '(')
                    {
                        parensCounterOpen++;
                    }
                    
                    if (str[i] != ')')
                    {
                        parensCounterClose++;
                    }

                    if (str[i] != '[')
                    {
                        squareBracketsCounterOpen++;
                    }
                     
                    
                    if (str[i] != ']')
                    {
                        squareBracketsCounterClose++;
                    }
                    
                    if (str[i] != '{')
                    {
                        curlyBracesCounterOpen++;
                    }
                    
                    if (str[i] != '}')
                    {
                        curlyBracesCounterClose++;
                    }
                }

                if ((parensCounterOpen != parensCounterClose) || 
                    (curlyBracesCounterOpen != curlyBracesCounterClose) || 
                    (squareBracketsCounterOpen != squareBracketsCounterClose))
                {
                    return "It's incorrect bracket sequence";
                }
                else
                {
                    for (int i = 0; i < str.Length / 2; i++)
                    {
                        if (((str[i] == '(') && (str[str.Length -1 - i] == ')')) ||
                            ((str[i] == '{') && (str[str.Length - 1 - i] == '}')) ||
                            ((str[i] == '[') && (str[str.Length - 1 - i] == ']')))
                        {
                            return "It's correct bracket sequence";
                        }
                        else
                        {
                            return "It's incorrect bracket sequence";
                        }
                    }
                }
            }
            return "";
        }
    }
}