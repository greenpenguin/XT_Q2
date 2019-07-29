using System;

namespace Task4_2
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            string[] array = {"aaaaaa", "aaaaa", "aaa", "aa"};

            SortStringClass sortStringClass = new SortStringClass();
            WorkWithConsoleClass workWithConsoleClass = new WorkWithConsoleClass();
            
            workWithConsoleClass.Output(array, false);
            
            var func = new Func<string, string, bool>(sortStringClass.Compare);
            sortStringClass.Sort(ref array, func);
            
            workWithConsoleClass.Output(array, true);

        }
    }
}