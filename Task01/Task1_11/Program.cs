namespace Task1_11
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            WorkWithConsoleClass workWithConsoleClass = new WorkWithConsoleClass();
            WorkWithStringClass workWithStringClass = new WorkWithStringClass();
            
            workWithConsoleClass.Output(workWithStringClass.CalculateAverageLength(workWithConsoleClass.Input()));
        }
    }
}