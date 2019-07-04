namespace Task1_8
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            WorkWithArrayClass workWithArrayClass = new WorkWithArrayClass();
            WorkWithConsoleClass workWithConsoleClass = new WorkWithConsoleClass();
            
            int[, ,] array = new int[7, 7, 3];
            
            workWithArrayClass.InputRandomArray(array, 7, 7, 3);
            workWithConsoleClass.ArrayOutput(array, false);
            
            workWithArrayClass.ChangeElements(array, 7, 7, 3);
            workWithConsoleClass.ArrayOutput(array, true);
            
        }
    }
}