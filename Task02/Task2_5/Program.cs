namespace Task2_5
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            WorkWithConsoleClass workWithConsoleClass = new WorkWithConsoleClass();
            
            User user = workWithConsoleClass.InputUserData();
            
            workWithConsoleClass.Output(user.ToString());
        }
    }
}