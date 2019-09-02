namespace Task7_2
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            WorkWithConsoleClass workWithConsoleClass = new WorkWithConsoleClass();
            WorkWithRegularExpressionsClass workWithRegularExpressionsClass = new WorkWithRegularExpressionsClass();
            
            workWithConsoleClass.Output(workWithRegularExpressionsClass.ReplaceHtmlTags(workWithConsoleClass.Input()));
        }
    }
}