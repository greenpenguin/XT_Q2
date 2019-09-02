namespace Task7_1
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            WorkWithConsoleClass workWithConsoleClass = new WorkWithConsoleClass();
            WorkWithRegularExpressionsClass workWithRegularExpressionsClass = new WorkWithRegularExpressionsClass();
            
            workWithConsoleClass.Output(workWithRegularExpressionsClass.IsDateContains(workWithConsoleClass.Input()));
        }
    }
}