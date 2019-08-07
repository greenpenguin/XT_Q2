using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace Task05
{
    public class FileEditingClass
    {
        private Dictionary<string, string> renamedFilesPath = new Dictionary<string, string>();
        
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
        public static void CopyTheFileToBackups(string fileName)
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
            
            List<string> backupedFiles = new List<string>();
            
            foreach (var file in allTextFiles)
            {
                foreach (var backupFile in allBackupTextFiles)
                {
                    /*Console.WriteLine(backupFile.Name.Substring(numOfSymbolAfterFirstBracket, numOfSymbolBeforeLastBracketNum) 
                    +" "+ dateTimeForBackup);*/
                    if ((backupFile.Name.Substring(numOfSymbolAfterFirstBracket, numOfSymbolBeforeLastBracketNum) ==
                         dateTimeForBackup) &&
                        (backupFile.Name.Substring(lastBracketNum) == file.Name) &&
                        !(IsFileRenamed(file.FullName)))
                    {
                        File.Copy(backupFile.FullName, file.FullName, true);
                        backupedFiles.Add(file.FullName);
                        workWithConsoleClass.PrintInfoAboutBackupedFile(file.FullName, dateTimeForBackup);
                    }

                    else if (IsFileRenamed(file.FullName))
                    {
                        File.Copy(TakeRenamedBackup(file.Name, dateTimeForBackup), file.FullName, true);
                        backupedFiles.Add(TakeRenamedBackup(file.Name, dateTimeForBackup));
                    }
                }
                
            }

            foreach (var file in allTextFiles)
            {
                if (!backupedFiles.Contains(file.FullName))
                {
                    File.Delete(file.FullName);
                }
            }
        }


        public void SaveNewPathForRenamedFiles(string oldPath, string newPath)
        {
            renamedFilesPath.Add(oldPath, newPath);
            //наверно сохраняет самый изначальный путь
            /*List<string> initialFilesPath = new List<string>();
            Dictionary<int, string> renamedFilesPath = new Dictionary<int, string>();
            
            if (!initialFilesPath.Contains(oldPath))
            {
                initialFilesPath.Add(oldPath);
            }

            if (!renamedFilesPath.Keys.Contains(initialFilesPath.IndexOf(oldPath)))
            {
                renamedFilesPath.Add(initialFilesPath.IndexOf(oldPath), newPath);
            }
            else
            {
                renamedFilesPath[initialFilesPath.IndexOf(oldPath)] = newPath;
            }
            */
        }

        private bool IsFileRenamed(string path)
        {
            if (renamedFilesPath.ContainsKey(path) || renamedFilesPath.ContainsValue(path))
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        /*private bool IsBackupExists(string fileName, string dateTime)
        {
            const int numOfSymbolAfterFirstBracket = 1; // number of symbol after first bracket in backup file name
            const int numOfSymbolBeforeLastBracketNum = 19; // number of symbol before last bracket in backup file name
            const int lastBracketNum = 21; // last bracket number in backup file name
            
            DirectoryInfo backupFolderDirectoryInfo = new DirectoryInfo(Directory.GetCurrentDirectory() + "/Backups");
            FileInfo[] allBackupTextFiles = backupFolderDirectoryInfo.GetFiles("*.txt",  SearchOption.AllDirectories);
            
            //DirectoryInfo textFilesDir = new DirectoryInfo(Directory.GetCurrentDirectory() + "/WatchedFolder");
            //FileInfo[] allTextFiles = textFilesDir.GetFiles("*.txt",  SearchOption.AllDirectories);

            //foreach (var file in allTextFiles)
            //{
                foreach (var backupFile in allBackupTextFiles)
                {
                    if ((backupFile.Name.Substring(numOfSymbolAfterFirstBracket,
                            numOfSymbolBeforeLastBracketNum) == dateTime) && (backupFile.Name.Substring(lastBracketNum) == fileName))
                    {
                        return true;
                    }
                }
            //}

            return false;

        }*/

        public string TakeRenamedBackup(string fileName, string dateTime)
        {
            const int numOfSymbolAfterFirstBracket = 1; // number of symbol after first bracket in backup file name
            const int numOfSymbolBeforeLastBracketNum = 19; // number of symbol before last bracket in backup file name
            const int lastBracketNum = 21; // last bracket number in backup file name
            
            foreach (var elem in renamedFilesPath)
            {
                if ((elem.Key.Substring(numOfSymbolAfterFirstBracket,
                         numOfSymbolBeforeLastBracketNum) == dateTime) &&
                    (elem.Key.Substring(lastBracketNum) == fileName))
                {
                    return elem.Key;
                }
                else if ((elem.Value.Substring(numOfSymbolAfterFirstBracket,
                              numOfSymbolBeforeLastBracketNum) == dateTime) &&
                         (elem.Value.Substring(lastBracketNum) == fileName))
                {
                    return elem.Value;
                }
            }

            return String.Empty;
        }
        //удаление удаленных файлов (мб в функцию выше дописать)
        //бекап переименованных файлов (словарь "изначальный путь - новый путь", имя меняется несколько раз => новый путь меняется)
    }
}