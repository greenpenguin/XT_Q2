using System;
using System.Linq;

namespace Epam.Talalaykina.Task5
{
    public class WorkWithConsoleClass
    {
        public string Input()
        {
            Console.WriteLine("Please, input a string:");
            
            string str = Console.ReadLine();

            for (int i = 0; i < str.Length; i++)
            {
                if ((str[i] != '(') && (str[i] != ')') && 
                    (str[i] != '[') && (str[i] != ']') && 
                    (str[i] != '{') && (str[i] != '}'))
                {
                    throw new ArgumentException("The string contains not only brackets!");
                }
            }
            
            return str;
        }

        public void Output(string message)
        {
            Console.WriteLine(message);
        }
    }
}