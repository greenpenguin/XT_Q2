namespace Task1_5
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            WorkWithConsoleClass workWithConsoleClass = new WorkWithConsoleClass();
            SumFunctionClass sumFunctionClass = new SumFunctionClass();
            
            workWithConsoleClass.Output(sumFunctionClass.Sum(1000));
        }
    }
}