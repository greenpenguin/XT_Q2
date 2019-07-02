using System;
using System.Linq;

namespace Epam.Talalaykina.Task3
{
    public class WorkWithConsoleClass
    {
        public string[] Input()
        {
            Console.WriteLine("Please, input a string:");
            
            string[] stringArray = Console.ReadLine().Split(new[] {" ", ",", ".", "!", "?", ";", ":", "-"}, StringSplitOptions.RemoveEmptyEntries)
                .Select(item => item.Trim())
                .Where(item => !string.IsNullOrEmpty(item)).ToArray();
            
            return stringArray;
        }

        public void Output(string str)
        {
            Console.WriteLine("Unique words in the string: " + str);
        }

    }
}