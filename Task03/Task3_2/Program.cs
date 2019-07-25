namespace Task3_2
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            WorkWithConsoleClass workWithConsoleClass = new WorkWithConsoleClass();
            WorkWithStringClass workWithStringClass = new WorkWithStringClass();
            
            workWithConsoleClass.Output(workWithStringClass.WordsCount(workWithConsoleClass.Input()));
        }
    }
}