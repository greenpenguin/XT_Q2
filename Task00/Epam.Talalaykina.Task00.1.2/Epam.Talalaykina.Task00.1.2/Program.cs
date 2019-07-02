namespace Epam.Talalaykina.Task00._1._2
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            WorkWithConsoleClass workWithConsoleClass = new WorkWithConsoleClass();
            IsNumberSimpleFunctionClass isNumberSimpleFunctionClass = new IsNumberSimpleFunctionClass();
            
            workWithConsoleClass.Output(isNumberSimpleFunctionClass.IsNumberSimpleCheck(workWithConsoleClass.Input()));
        }
    }
}