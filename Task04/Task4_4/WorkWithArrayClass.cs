using System;

namespace Task4_4
{
    public static class WorkWithArrayClass
    {
        public static void InputRandomArray(int[] array)
        {
            Random rand = new Random();
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = rand.Next(0, 100);
            }
        }
        
        public static int Sum(this int[] arr)
        {
            int sum = 0;
            foreach (var item in arr)
            {
                sum += item;
            }

            return sum;
        }

        public static double Sum(this double[] arr)
        {
            double sum = 0;
            foreach (var item in arr)
            {
                sum += item;
            }

            return sum;
        }
        
    }
    
    
}