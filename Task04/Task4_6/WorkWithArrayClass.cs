using System;
using System.Collections.Generic;
using System.Linq;

namespace Task4_6
{
    public class WorkWithArrayClass
    {
        public void InputRandomArray(int[] array)
        {
            Random rand = new Random();
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = rand.Next(-100, 100);
            }
        }
        
        public List<int> SearchPositiveElements(int[] array)
        {
            List<int> positiveElementsList = new List<int>();

            foreach (var element in array)
            {
                if (element > 0)
                {
                    positiveElementsList.Add(element);
                }
            }

            return positiveElementsList;
        }
        
        public List<int> GetPositiveElements(int[] array, Predicate<int> condition)
        {
            List<int> positiveElementsList = new List<int>();
            foreach (var element in array)
            {
                if (condition(element))
                {
                    positiveElementsList.Add(element);
                }
            }

            return positiveElementsList;
        }
        
        public List<int> DelegatSearch(int[] arr)
        {
            Predicate<int> predicate = IsElementGreaterThanZero;
            List<int> positiveElementsList = GetPositiveElements(arr, predicate);
            return positiveElementsList;
        }

        public List<int> AnonSearch(int[] array)
        {
            Predicate<int> predicate = delegate (int number)
            {
                if (number > 0)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            };

            List<int> positiveElementsList = GetPositiveElements(array, predicate);
            return positiveElementsList;
        }

        public List<int> LambdaSearch(int[] array)
        {
            Predicate<int> predicate = (x) => (x > 0 ? true : false);
            List<int> positiveElementsList = GetPositiveElements(array, predicate);
            return positiveElementsList;
        }

        public List<int> LinqSearch(int[] array)
        {
            List<int> positiveElementsList = new List<int>();
            var linq = array.Where(x => x > 0);
            foreach (var element in linq)
            {
                 positiveElementsList.Add(element);   
            }
            return positiveElementsList;
        }

        public bool IsElementGreaterThanZero(int number)
        {
            if (number > 0)
            {
                return true;
            }

            return false;
        }
    }
}