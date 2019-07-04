namespace Task1_1
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            WorkWithConsoleClass workWithConsoleClass = new WorkWithConsoleClass();
            WorkWithRectangleClass workWithRectangleClass = new WorkWithRectangleClass();
            
            workWithConsoleClass.Output(workWithRectangleClass.RectangleAreaCalculation(workWithConsoleClass.Input()));
        }
    }
}