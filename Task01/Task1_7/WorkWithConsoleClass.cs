using System;
using System.Collections.Generic;

namespace Task1_7
{
    public class WorkWithConsoleClass
    {
        public void ArrayOutput(int[] array, bool isSorted)
        {
            if (isSorted)
            {
                Console.WriteLine("The array after sorting:");
            }
            else
            {
                Console.WriteLine("The array before sorting:");
            }
            
            foreach (var element in array)
            {
                Console.Write(element + " ");
            }
            
            Console.WriteLine();
        }

        public void TakeMinAndMaxElements(List<int> minAndMaxElements)
        {
            Console.WriteLine("Min elem: " + minAndMaxElements[0] + ", max elem: " + minAndMaxElements[1]);
        }
    }
}