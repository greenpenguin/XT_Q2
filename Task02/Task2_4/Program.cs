using System;

namespace Task2_4
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            WorkWithConsoleClass workWithConsoleClass = new WorkWithConsoleClass();
            MyStringOperationsClass myStringOperationsClass = new MyStringOperationsClass();
            
            MyString firstMyString = new MyString(workWithConsoleClass.Input());
            MyString secondMyString = new MyString(workWithConsoleClass.Input());
            
            workWithConsoleClass.OutputMyString(firstMyString.SumMyString(secondMyString, firstMyString));
            
            workWithConsoleClass.OutputMyString(myStringOperationsClass.AddSubstring(firstMyString, new MyString("test"), 1));

            workWithConsoleClass.OutputIsEqualInformation(myStringOperationsClass.IsEqual(firstMyString, secondMyString));
            
            workWithConsoleClass.OutputSearchCharInformation(myStringOperationsClass.SearchChar(firstMyString, 'a'));
            
            workWithConsoleClass.OutputMyString(myStringOperationsClass.TakeSubstring(firstMyString, 2));
        }
    }
}