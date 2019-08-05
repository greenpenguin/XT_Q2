using System;
using System.IO;

namespace Task05
{
    public class FileEditingClass
    {
        /// <summary>
        /// This method copies all files from the watching folder to the backup folder
        /// </summary>
        /// 
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

        /// <summary>
        /// This method copies one file from the watching folder to the backup folder (by name)
        /// </summary>
        /// 
        /*public static void CopyTheFileToBackups(string fileName)
        {
            string backupFolderPath = Directory.GetCurrentDirectory() + "/Backups";

            DirectoryInfo textFilesDir = new DirectoryInfo(Directory.GetCurrentDirectory() + "/WatchedFolder");
            FileInfo[] allTextFiles = textFilesDir.GetFiles("*.txt",  SearchOption.AllDirectories);
            foreach (var file in allTextFiles)
            {
                if (file.Name == fileName)
                {
                    string thisDateTime = DateTime.Now.ToString("yyyy.MM.dd-HH.mm.ss");
                    string destFile = Path.Combine(backupFolderPath, "(" + thisDateTime + ")" + file.Name);
                    File.Copy(file.FullName, destFile, true);
                }
            }
        }*/

        public static void BackupAllNotRenamedFiles(string dateTimeForBackup)
        {
            const int numOfSymbolAfterFirstBracket = 1; // number of symbol after first bracket in backup file name
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
            }
        }
    }
}