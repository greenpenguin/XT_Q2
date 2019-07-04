using System;
using System.Collections.Generic;

namespace Task1_12
{
    public class WorkWithConsoleClass
    {
        public List<string> Input()
        {
            Console.WriteLine("Please, input the first string");
            string firstString = Console.ReadLine();
            
            Console.WriteLine("Please, input the second string");
            string secondString = Console.ReadLine();
            
            List<string> strings = new List<string>();
            strings.Add(firstString);
            strings.Add(secondString);

            return strings;
        }

        public void Output(string result)
        {
            Console.WriteLine("The result string is: " + result);
        }
    }
}