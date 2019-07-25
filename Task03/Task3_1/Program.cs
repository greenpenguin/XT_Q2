namespace Task3_1
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            WorkWithConsoleClass workWithConsoleClass = new WorkWithConsoleClass();
            WorkWithListClass workWithListClass = new WorkWithListClass();
            
            workWithListClass.RemoveFromList(workWithListClass.CreateList(workWithConsoleClass.Input()));
        }
    }
}