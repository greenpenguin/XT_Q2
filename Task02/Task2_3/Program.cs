namespace Task2_3
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            WorkWithConsoleClass workWithConsoleClass = new WorkWithConsoleClass();
            
            User user = new User(workWithConsoleClass.InputUserData());
            
            workWithConsoleClass.Output(user.ToString());
        }
    }
}