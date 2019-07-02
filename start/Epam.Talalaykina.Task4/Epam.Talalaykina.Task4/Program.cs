namespace Epam.Talalaykina.Task4
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            WorkWithConsoleClass workWithConsoleClass = new WorkWithConsoleClass();
            FactorialFunctionClass factorialFunctionClass = new FactorialFunctionClass();

            workWithConsoleClass.Output(factorialFunctionClass.FactorialCalculate(workWithConsoleClass.Input()));
        }
    }
}