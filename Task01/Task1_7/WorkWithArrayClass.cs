using System;
using System.Collections.Generic;

namespace Task1_7
{
    public class WorkWithArrayClass
    {
        public void InputRandomArray(int[] array)
        {
            Random rand = new Random();
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = rand.Next(0, 100);
            }
        }

        public void SortArray(int[] array, int first, int last)
        {
            int p = array[(last - first)/2 + first];
            int temp;
            int i = first;
            int j = last;
            
            while(i <= j) 
            {
                while (array[i] < p && i <= last)
                {
                    ++i;
                }

                while (array[j] > p && j >= first)
                {
                    --j;
                }
                
                if (i <= j) 
                {
                    temp = array[i];
                    array[i] = array[j];
                    array[j] = temp;
                    ++i; 
                    --j;
                }
            }

            if (j > first)
            {
                SortArray(array, first, j);
            }

            if (i < last)
            {
                SortArray(array, i, last);
            }
        }

        public List<int> TakeFirstAndLastArrayElement(int[] array)
        {
            List<int> firstAndLastElements = new List<int>();
            firstAndLastElements.Add(array[0]);
            firstAndLastElements.Add(array[array.Length - 1]);

            return firstAndLastElements;
        }
        
    }
}
