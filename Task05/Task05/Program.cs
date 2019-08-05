using System;
using System.IO;

namespace Task05
{
    class Program
    {
        static void Main(string[] args)
        {
            //WorkWithConsoleClass.ChooseDateAndTimeForBackup();
            //FileEditingClass.CopyAllFilesToBackups();
            //Watcher.Run();
            /*const int numOfSymbolAfterFirstBracket = 1; // number of symbol after first bracket in backup file name
            const int numOfSymbolBeforeLastBracketNum = 19; // number of symbol before last bracket in backup file name
            const int lastBracketNum = 21; // last bracket number in backup file name
            
            DirectoryInfo backupFolderDirectoryInfo = new DirectoryInfo(Directory.GetCurrentDirectory() + "/Backups");
            FileInfo[] allBackupTextFiles = backupFolderDirectoryInfo.GetFiles("*.txt",  SearchOption.AllDirectories);
            
            string dateTimeForBackup = WorkWithConsoleClass.ChooseDateAndTimeForBackup();

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
            }*/
        }
        
    }
    
    
}