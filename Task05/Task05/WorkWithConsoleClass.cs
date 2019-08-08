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

        public void PrintInfoAboutBackupedFile(string fileName, string dateTime)
        {
            Console.WriteLine($"File {fileName} is rollback to {dateTime}");
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

        public static void ConsoleInterface()
        {
            Console.WriteLine("Hello, this is a backup system for text files.");

            bool isInput = true;

            while (isInput)
            {
                Console.WriteLine("What mode of operation to include?"
                                  + Environment.NewLine + "\t 1: watcher mode"
                                  + Environment.NewLine + "\t 2: rollback changes"
                                  + Environment.NewLine + "\t 3: exit from the program");
                if (int.TryParse(Console.ReadLine(), out int result))
                {
                    switch (result)
                    {
                        case 1:
                        {
                            Watcher.Run();
                            break;
                        }

                        case 2:
                        {
                            string dateTimeForBackup = ChooseDateAndTimeForBackup();
                            FileEditingClass fileEditingClass = new FileEditingClass();
                            fileEditingClass.Backup(dateTimeForBackup);
                            break;
                        }

                        case 3:
                        {
                            isInput = false;
                            break;
                        }
                        
                        default:
                        {
                            Console.WriteLine("Unknown command!");
                            break;
                        }
                    }
                }
            }
        }
    }
}
