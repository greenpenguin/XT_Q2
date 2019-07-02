namespace Epam.Talalaykina.Task3
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            WorkWithConsoleClass workWithConsoleClass = new WorkWithConsoleClass();
            WorkWithStringClass workWithStringClass = new WorkWithStringClass();
            
            workWithConsoleClass.Output(workWithStringClass.SelectUniqueWords(workWithConsoleClass.Input()));
        }
    }
}