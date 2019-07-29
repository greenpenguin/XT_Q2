using System;

namespace Task4_1
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            ArraySortClass arraySortClass = new ArraySortClass();
            WorkWithConsoleClass workWithConsoleClass = new WorkWithConsoleClass();
            
            int[] array = new int[50];
            
            arraySortClass.InputRandomArray(array);
            workWithConsoleClass.ArrayOutput(array, false);
            
            var func = new Func<int, int, bool>(arraySortClass.Compare);
            arraySortClass.Sort(ref array, func);
           
            workWithConsoleClass.ArrayOutput(array, true);
            
        }
    }
}