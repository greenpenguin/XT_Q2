using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace Task05
{
    public class FileEditingClass
    {
        private Dictionary<string, string> renamedFilesPath = new Dictionary<string, string>();
        
        public static void CopyAllFilesToBackups()
        {
            string backupFolderPath = Directory.GetCurrentDirectory() + "/Backups";

            DirectoryInfo textFilesDir = new DirectoryInfo(Directory.GetCurrentDirectory() + "/WatchedFolder");
            FileInfo[] allTextFiles = textFilesDir.GetFiles("*.txt",  SearchOption.AllDirectories);
            foreach (var file in allTextFiles)
            {
                string thisDateTime = DateTime.Now.ToString("yyyy.MM.dd-HH.mm.ss");
                string destFile = Path.Combine(backupFolderPath, "(" + thisDateTime + ")" + file.Name);
                File.Copy(file.FullName, destFile, true);
            }
        }

        public void Backup(string dateTimeForBackup)
        {
            const int numOfSymbolAfterFirstBracket = 1; // number of symbol after first bracket in backup file name
            const int numOfSymbolBeforeLastBracketNum = 19; // number of symbol before last bracket in backup file name
            const int lastBracketNum = 21; // last bracket number in backup file name
            WorkWithConsoleClass workWithConsoleClass = new WorkWithConsoleClass();
            
            DirectoryInfo backupFolderDirectoryInfo = new DirectoryInfo(Directory.GetCurrentDirectory() + "/Backups");
            FileInfo[] allBackupTextFiles = backupFolderDirectoryInfo.GetFiles("*.txt",  SearchOption.AllDirectories);
            
            DirectoryInfo textFilesDir = new DirectoryInfo(Directory.GetCurrentDirectory() + "/WatchedFolder");
            FileInfo[] allTextFiles = textFilesDir.GetFiles("*.txt",  SearchOption.AllDirectories);
            
            foreach (var file in allTextFiles)
            {
                File.Delete(file.FullName);
            }
            
            foreach (var backupFile in allBackupTextFiles)
            {
                if ((backupFile.Name.Substring(numOfSymbolAfterFirstBracket, numOfSymbolBeforeLastBracketNum) ==
                     dateTimeForBackup))
                {
                    File.Copy(backupFile.FullName, textFilesDir + "/" + backupFile.Name.Substring(lastBracketNum), true);
                    workWithConsoleClass.PrintInfoAboutBackupedFile(textFilesDir + backupFile.Name, dateTimeForBackup);
                }
            }
        }


        public void SaveNewPathForRenamedFiles(string oldPath, string newPath)
        {
            renamedFilesPath.Add(oldPath, newPath);
        }

    }
}