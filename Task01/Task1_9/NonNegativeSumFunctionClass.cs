using System;

namespace Task1_9
{
    public class NonNegativeSumFunctionClass
    {
        public void InputRandomArray(int[] array)
        {
            Random rand = new Random();
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = rand.Next(-50, 100);
            }
        }
        
        public int SumElements(int[] array)
        {
            int sum = 0;
            for (int i = 0; i < array.Length; i++)
            if (array[i] > 0)
            {
                sum += array[i];
            }

            return sum;
        }
    }
}