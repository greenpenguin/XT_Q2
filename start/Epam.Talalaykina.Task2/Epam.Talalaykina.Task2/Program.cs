namespace Epam.Talalaykina.Task2
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            WorkWithConsoleClass workWithConsoleClass = new WorkWithConsoleClass();
            
            int[] array = workWithConsoleClass.InputArray();
            
            WorkWithArrayClass workWithArrayClass = new WorkWithArrayClass();
            workWithArrayClass.SortingArray(array);
            workWithArrayClass.SearchingElementInformation(array);
            
        }
    }
}