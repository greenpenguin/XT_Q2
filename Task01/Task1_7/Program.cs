namespace Task1_7
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            WorkWithArrayClass workWithArrayClass = new WorkWithArrayClass();
            WorkWithConsoleClass workWithConsoleClass = new WorkWithConsoleClass();
            
            int[] array = new int[50];
            
            workWithArrayClass.InputRandomArray(array);
            workWithConsoleClass.ArrayOutput(array, false);
            
            workWithArrayClass.SortArray(array, 0, array.Length - 1);
            workWithConsoleClass.ArrayOutput(array, true);
            
            workWithConsoleClass.TakeMinAndMaxElements(workWithArrayClass.TakeFirstAndLastArrayElement(array));
        }
    }
}