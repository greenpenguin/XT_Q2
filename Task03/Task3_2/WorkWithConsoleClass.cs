using System;
using System.Collections.Generic;
using System.Linq;

namespace Task3_2
{
    public class WorkWithConsoleClass
    {
        public string[] Input()
        {
            Console.WriteLine("Please, input a string:");
            
            string[] stringArray = Console.ReadLine().ToLower().Split(new[] {" ", "."}, StringSplitOptions.RemoveEmptyEntries)
                .Select(item => item.Trim())
                .Where(item => !string.IsNullOrEmpty(item)).ToArray();
            
            return stringArray;
        }

        public void Output(Dictionary<string, int> wordsCount)
        {
            foreach (var word in wordsCount)
            {
                Console.WriteLine("Word " + word.Key + " occurs " + word.Value + " times");
            }
        }
    }
}