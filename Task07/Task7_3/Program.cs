namespace Task7_3
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            WorkWithConsoleClass workWithConsoleClass = new WorkWithConsoleClass();
            WorkWithRegularExpressionsClass workWithRegularExpressionsClass = new WorkWithRegularExpressionsClass();
            
            workWithRegularExpressionsClass.EmailSearch(workWithConsoleClass.Input());
        }
    }
}