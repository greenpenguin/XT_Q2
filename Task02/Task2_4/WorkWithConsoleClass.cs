using System;
using System.Collections.Generic;

namespace Task2_4
{
    public class WorkWithConsoleClass
    {
        public string Input()
        {
            Console.WriteLine("Input the string");
            string inputStr = Console.ReadLine();

            return inputStr;
        }

        public void OutputString(string str)
        {
            Console.WriteLine(str);
        }

        public void OutputMyString(MyString myString)
        {
            for (int i = 0; i < myString.TakeLength(); i++)
            {
                Console.Write(myString.TakeChar(i));
            }
            Console.WriteLine();
        }

        public void OutputIsEqualInformation(bool isEqual)
        {
            if (isEqual)
            {
                Console.WriteLine("Strings are equal");
            }
            else
            {
                Console.WriteLine("Strings aren't equal");
            }
        }
        
        public void OutputSearchCharInformation(int index)
        {
            if (index == -1)
            {
                Console.WriteLine("Char doesn't exist");
            }
            else
            {
                Console.WriteLine("Index of the char in this string " + index);
            }
        }
        
    }
}