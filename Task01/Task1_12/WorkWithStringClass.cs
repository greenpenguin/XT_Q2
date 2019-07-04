using System;
using System.Collections.Generic;
using System.Text;

namespace Task1_12
{
    public class WorkWithStringClass
    {
        public List<char> TakeElementsForDoubling(List<string> strings)
        {
            string secondString = strings[1];
            
            List<char> secondStringChars = new List<char>();
            
            for (int i = 0; i < secondString.Length; i++)
            {
                if (!secondStringChars.Contains(secondString[i]))
                {
                    secondStringChars.Add(secondString[i]);
                }
            }

            return secondStringChars;
        }

        public string DoubleElements(List<string> strings, List<char> secondStringChars)
        {
            string firstString = strings[0];
            StringBuilder newString = new StringBuilder();
            
            foreach (var element in firstString)
            {
                newString.Append(element);
                if (secondStringChars.Contains(element))
                {
                    newString.Append(element);
                }
            }

            return newString.ToString();
        }
    }
}