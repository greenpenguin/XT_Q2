namespace Epam.Talalaykina.Task00._1._3
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            WorkWithConsoleClass workWithConsoleClass = new WorkWithConsoleClass();
            SquareCreatingClass squareCreatingClass = new SquareCreatingClass();
            
            workWithConsoleClass.Output(squareCreatingClass.SquareCreating(workWithConsoleClass.Input()));
        }
    }
}