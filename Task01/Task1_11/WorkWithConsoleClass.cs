using System;
using System.Collections.Generic;

namespace Task1_11
{
    public class WorkWithConsoleClass
    {
        public List<int> Input()
        {
            Console.WriteLine("Please, input the string");
            string inputString = Console.ReadLine();

            int length = 0;
            
            List<int> lengths = new List<int>();
            
            for (int i = 0; i < inputString.Length; i++)
            {
                
                if ((Char.IsPunctuation(inputString[i])) || (Char.IsSeparator(inputString[i])))
                {
                    if (length != 0)
                    {
                        lengths.Add(length);
                        length = 0;
                    }
                }
                else
                {
                    length++;
                }
            }

            return lengths;

        }

        public void Output(double result)
        {
            Console.WriteLine("The average words length of this string is " + result);
            
        }
    }
}