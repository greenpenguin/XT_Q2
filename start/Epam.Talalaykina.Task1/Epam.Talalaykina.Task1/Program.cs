using System;

namespace Epam.Talalaykina.Task1
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            WorkWithConsoleClass workWithConsoleClass = new WorkWithConsoleClass();
            
            int[] array = workWithConsoleClass.InputArray();
            
            workWithConsoleClass.OutputArrayWithMessage(array, "The array before sorting:");
            
            SortingClass sortingClass = new SortingClass();
            sortingClass.SortingArray(array);
            
            workWithConsoleClass.OutputArrayWithMessage(array, "The array after sorting:");
            
        }
    }
}