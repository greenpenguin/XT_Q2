using System;
using System.Threading.Tasks;

namespace Task4_3
{
    public class ArraySortClass
    {
        private event Action<int[]> SortStopped;

        public async Task SortStart<T>(int[] arr, Func<int, int, bool> compare, Action<int[]> isStopped)
        {
            SortStopped += isStopped;
            await Task.Run(() => Sort<int>(ref arr, compare));
            SortStopped?.Invoke(arr);
        }
        
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