namespace Task4_6
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            WorkWithConsoleClass workWithConsoleClass = new WorkWithConsoleClass();
            WorkWithArrayClass workWithArrayClass = new WorkWithArrayClass();
            int[] array = new int[50];
            
            workWithArrayClass.InputRandomArray(array);
            workWithConsoleClass.ArrayOutput(array);
            workWithConsoleClass.positiveElementsListOutput("Search:", workWithArrayClass.SearchPositiveElements(array));
            workWithConsoleClass.positiveElementsListOutput("Delegat search:", workWithArrayClass.DelegatSearch(array));
            workWithConsoleClass.positiveElementsListOutput("Anon search:", workWithArrayClass.AnonSearch(array));
            workWithConsoleClass.positiveElementsListOutput("Lambda search:", workWithArrayClass.LambdaSearch(array));
            workWithConsoleClass.positiveElementsListOutput("LINQ search:", workWithArrayClass.LinqSearch(array));
        }
    }
}