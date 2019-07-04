using System;

namespace Task1_8
{
    public class WorkWithArrayClass
    {
        public void InputRandomArray(int[,,] array, int i, int j, int k)
        {
            Random rand = new Random();
            
            for (int startI = 0; startI < i; startI++)
            {
                for (int startJ = 0; startJ < j; startJ++)
                {
                    for (int startK = 0; startK < k; startK++)
                    {
                        array[startI, startJ, startK] = rand.Next(-50, 50);
                    }
                }
            }
        }
        
        public void ChangeElements(int[,,] array, int i, int j, int k)
        {
            
            for (int startI = 0; startI < i; startI++)
            {
                for (int startJ = 0; startJ < j; startJ++)
                {
                    for (int startK = 0; startK < k; startK++)
                    {
                        if (array[startI, startJ, startK] > 0)
                        {
                            array[startI, startJ, startK] = 0;
                        }
                    }
                }
            }
        }
    }
}