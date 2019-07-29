using System;
using System.Collections.Generic;

namespace Task4_6
{
    public class WorkWithConsoleClass
    {
        public void ArrayOutput(int[] array)
        {
            Console.WriteLine("The array:");
            foreach (var element in array)
            {
                Console.Write(element + " ");
            }
            Console.WriteLine();
        }

        public void positiveElementsListOutput(string message, List<int> positiveElementsList)
        {
            Console.WriteLine(message + "\nThis elements are greater than zero:");
            foreach (var element in positiveElementsList)
            {
                Console.Write(element + " ");
            }
            Console.WriteLine();
            Console.WriteLine();
        }
    }
}