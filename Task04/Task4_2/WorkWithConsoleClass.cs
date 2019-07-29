using System;

namespace Task4_2
{
    public class WorkWithConsoleClass
    {
        public void Output(string[] array, bool isSorted)
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