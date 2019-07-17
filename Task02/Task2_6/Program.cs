namespace Task2_6
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            WorkWithConsole workWithConsole = new WorkWithConsole();
            Ring ring = new Ring(workWithConsole.InputRingData());
            
            workWithConsole.Output(ring.AreaOfRing(), ring.SumOfLengthsOfCircles());
        }
    }
}