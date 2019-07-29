namespace Task4_4
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            WorkWithConsoleClass workWithConsoleClass = new WorkWithConsoleClass();
            
            int[] array = new int[50];
            
            WorkWithArrayClass.InputRandomArray(array);
            workWithConsoleClass.ArrayOutput(array);
            workWithConsoleClass.SumOutput(array.Sum());
            
        }
    }
}