using System;

namespace Task1_9
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

        public void SumOutput(int sum)
        {
            Console.WriteLine("The summa: " + sum);
        }
    }
}