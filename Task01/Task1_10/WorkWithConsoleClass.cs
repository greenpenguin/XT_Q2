using System;

namespace Task1_10
{
    public class WorkWithConsoleClass
    {
        public void ArrayOutput(int[,] array, int i, int j)
        {
            Console.WriteLine("The array:");

            for (int startI = 0; startI < i; startI++)
            {
                for (int startJ = 0; startJ < j; startJ++)
                {
                    Console.Write(array[startI, startJ] + " ");
                }
                Console.WriteLine();
            }
            
            Console.WriteLine();
        }

        public void SumOutput(int sum)
        {
            Console.WriteLine("The summa: " + sum);
        }
    }
}