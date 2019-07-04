using System.Collections.Generic;

namespace Task1_12
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            WorkWithConsoleClass workWithConsoleClass = new WorkWithConsoleClass();
            WorkWithStringClass workWithStringClass = new WorkWithStringClass();

            List<string> strings = workWithConsoleClass.Input();

            List<char> elementsForDoubling = workWithStringClass.TakeElementsForDoubling(strings);
            
            workWithConsoleClass.Output(workWithStringClass.DoubleElements(strings, elementsForDoubling));
            
        }
    }
}