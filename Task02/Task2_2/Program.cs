namespace Task2_2
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            WorkWithConsoleClass workWithConsoleClass = new WorkWithConsoleClass();
            
            TriangleClass triangle = new TriangleClass(workWithConsoleClass.Input());
            
            workWithConsoleClass.Output(triangle.GetArea(), triangle.GetPerimeter());
        }
    }
}