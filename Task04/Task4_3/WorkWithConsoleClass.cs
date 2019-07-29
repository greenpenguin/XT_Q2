using System;

namespace Task4_3
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
    }
}