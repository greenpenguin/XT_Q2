﻿namespace Task4_5
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            WorkWithConsoleClass workWithConsoleClass = new WorkWithConsoleClass();
            WorkWithStringClass workWithStringClass = new WorkWithStringClass();
            
            workWithConsoleClass.Output(workWithStringClass.IsPositiveInt(workWithConsoleClass.Input()));
        }
    }
}