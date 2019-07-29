﻿using System;

namespace Task4_2
{
    public class SortStringClass
    {
        public bool Compare(int num1, int num2)
        {
            return num1 > num2;
        }

        public bool Compare(string num1, string num2)
        {
            return num1.Length > num2.Length;
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