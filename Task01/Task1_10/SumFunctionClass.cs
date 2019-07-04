using System;

namespace Task1_10
{
    public class SumFunctionClass
    {
        public void InputRandomArray(int[,] array, int i, int j)
        {
            Random rand = new Random();
            
            for (int startI = 0; startI < i; startI++)
            {
                for (int startJ = 0; startJ < j; startJ++)
                {
                    array[startI, startJ] = rand.Next(-50, 50);
                }
            }
        }
        
        public int SummaFunction(int[,] array, int i, int j)
        {
            int sum = 0;
            for (int startI = 0; startI < i; startI++)
            {
                for (int startJ = 0; startJ < j; startJ++)
                {
                    if ((startI + startJ) % 2 == 0)
                    {
                        sum += array[startI, startJ];
                    }
                }
            }

            return sum;
        }
    }
}
