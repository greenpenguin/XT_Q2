namespace Task2_1
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            WorkWithConsoleClass workWithConsoleClass = new WorkWithConsoleClass();
            
            RoundClass round = new RoundClass(workWithConsoleClass.Input());
            
            workWithConsoleClass.Output(round.GetAreaOfRound(), round.GetLengthOfRound());
        }
    }
}