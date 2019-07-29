using System;

namespace Task4_1
{
    public class ArraySortClass
    {
        public void InputRandomArray(int[] array)
        {
            Random rand = new Random();
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = rand.Next(0, 100);
            }
        }
        
        public bool Compare(int num1, int num2)
        {
            return num1 > num2;
        }
        
        public void Sort<T>(ref T[] array, Func<T, T, bool> comparer)
        {
            for (int i = 1; i < array.Length; i++)
            {
                T cur = array[i];
                int j = i;
                while (j > 0 && comparer.Invoke(array[j - 1], cur))
                {
                    array[j] = array[j - 1];
                    j--;
                }
                array[j] = cur;
            }
        }
    }
}