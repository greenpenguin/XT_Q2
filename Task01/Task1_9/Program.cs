namespace Task1_9
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            WorkWithConsoleClass workWithConsoleClass = new WorkWithConsoleClass();
            NonNegativeSumFunctionClass nonNegativeSumFunctionClass = new NonNegativeSumFunctionClass();
            
            int[] array = new int[50];
            
            nonNegativeSumFunctionClass.InputRandomArray(array);
            workWithConsoleClass.ArrayOutput(array);
            
            workWithConsoleClass.SumOutput(nonNegativeSumFunctionClass.SumElements(array));
        }
    }
}