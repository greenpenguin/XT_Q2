namespace Epam.Talalaykina.Task5
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            WorkWithConsoleClass workWithConsoleClass = new WorkWithConsoleClass();
            WorkWithStringClass workWithStringClass = new WorkWithStringClass();
            workWithConsoleClass.Output(workWithStringClass.CheckingOfBrackets(workWithConsoleClass.Input()));
        }
    }
}