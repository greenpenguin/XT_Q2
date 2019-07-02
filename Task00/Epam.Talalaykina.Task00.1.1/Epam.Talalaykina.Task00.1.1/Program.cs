namespace Epam.Talalaykina.Task00._1._1
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            WorkWithConsoleClass workWithConsoleClass = new WorkWithConsoleClass();
            FunctionClass functionClass = new FunctionClass();
            
            workWithConsoleClass.Output(functionClass.StringCreation(workWithConsoleClass.Input()));
        }
    }
}