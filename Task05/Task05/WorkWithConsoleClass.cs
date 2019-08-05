using System;

namespace Task05
{
    public class WorkWithConsoleClass
    {
        public static void ExitWatcherMode()
        {
            Console.WriteLine("Press 'q' to exit watcher mode.");
            while (Console.Read() != 'q') ;
        }

        public static string ChooseDateAndTimeForBackup()
        {
            Console.WriteLine("Please, input date and time to roll back changes.");
            string outDateTime = String.Empty;
            if (DateTime.TryParse(Console.ReadLine(), out var dateTime))
            {
                outDateTime = dateTime.ToString("yyyy.MM.dd-HH.mm.ss");
            }
            else
            {
                new ArgumentException("Wrong date and time format!");
            }
            
            return outDateTime;
        }
    }
}