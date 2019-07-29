using System;

namespace Task4_3
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
            
            Action<int[]> isDone = (x) =>
            {
                workWithConsoleClass.ArrayOutput(array, true);
            };
            
            var compare = new Func<int, int, bool>(arraySortClass.Compare);
            var thread = arraySortClass.SortStart<int>(array, compare, isDone);

            thread.Wait();
        }
    }
}