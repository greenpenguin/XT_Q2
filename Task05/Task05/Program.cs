using System;
using System.IO;

namespace Task05
{
    class Program
    {
        static void Main(string[] args)
        {
            //WorkWithConsoleClass.ChooseDateAndTimeForBackup();
            FileEditingClass.CopyAllFilesToBackups();
            WorkWithConsoleClass.ConsoleInterface();
            /*//Watcher.Run();
            /*const int numOfSymbolAfterFirstBracket = 1; // number of symbol after first bracket in backup file name
            const int numOfSymbolBeforeLastBracketNum = 19; // number of symbol before last bracket in backup file name
            const int lastBracketNum = 21; // last bracket number in backup file name
            
            DirectoryInfo backupFolderDirectoryInfo = new DirectoryInfo(Directory.GetCurrentDirectory() + "/Backups");
            FileInfo[] allBackupTextFiles = backupFolderDirectoryInfo.GetFiles("*.txt",  SearchOption.AllDirectories);
            
            

            DirectoryInfo textFilesDir = new DirectoryInfo(Directory.GetCurrentDirectory() + "/WatchedFolder");
            FileInfo[] allTextFiles = textFilesDir.GetFiles("*.txt",  SearchOption.AllDirectories);
            foreach (var file in allTextFiles)
            {
                foreach (var backupFile in allBackupTextFiles)
                {
                    if ((backupFile.Name.Substring(numOfSymbolAfterFirstBracket, numOfSymbolBeforeLastBracketNum) ==
                         dateTimeForBackup) &&
                        (backupFile.Name.Substring(lastBracketNum) == file.Name))
                    {
                        File.Copy(backupFile.FullName, file.FullName, true);
                        Console.WriteLine("ok");
                    }
                }
            }#1#
            
            /*string backupFolderPath = Directory.GetCurrentDirectory() + "/Backups";

            DirectoryInfo textFilesDir = new DirectoryInfo(Directory.GetCurrentDirectory() + "/WatchedFolder");
            FileInfo[] allTextFiles = textFilesDir.GetFiles("*.txt",  SearchOption.AllDirectories);
            foreach (var file in allTextFiles)
            {
                string thisDateTime = DateTime.Now.ToString("yyyy.MM.dd-HH.mm.ss");
                string destFile = Path.Combine(backupFolderPath, "(" + thisDateTime + ")" + file.Name);
                File.Copy(file.FullName, destFile, true);
            }#1#
            */
            /*string dateTimeForBackup = WorkWithConsoleClass.ChooseDateAndTimeForBackup();
            FileEditingClass fileEditingClass = new FileEditingClass();
            fileEditingClass.Backup(dateTimeForBackup);*/
            //2019.08.05-04.30.30
            //05.08.2019 04:30:30
            //(2019.08.06-15.49.37)file2 05.08.2019 15:49:37  2019.08.07-18.00.31 08.07.2019 18:00:31
            //месяц - число - год   08.08.2019 04:11:33)file1 — копия*/
            
            
        }
        
    }
    
    
}