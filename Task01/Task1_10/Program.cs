namespace Task1_10
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            WorkWithConsoleClass workWithConsoleClass = new WorkWithConsoleClass();
            SumFunctionClass sumFunctionClass = new SumFunctionClass();
            
            int[,] array = new int[10, 10];
            
            sumFunctionClass.InputRandomArray(array, 10, 10);
            
            workWithConsoleClass.ArrayOutput(array, 10, 10);
            
            workWithConsoleClass.SumOutput(sumFunctionClass.SummaFunction(array, 10, 10));
        }
    }
}