using System;
using System.IO;

namespace Task05
{
    public class Watcher
    {
        
        public static void Run()
        {
            using (FileSystemWatcher watcher = new FileSystemWatcher())
            {
                watcher.Path = Directory.GetCurrentDirectory() + "/WatchedFolder";

                watcher.NotifyFilter = NotifyFilters.LastAccess
                                       | NotifyFilters.LastWrite
                                       | NotifyFilters.FileName
                                       | NotifyFilters.DirectoryName;

                watcher.Filter = "*.txt";
                watcher.IncludeSubdirectories = true;
                watcher.Changed += OnChanged;
                watcher.Created += OnChanged;
                watcher.Deleted += OnChanged;
                watcher.Renamed += OnRenamed;

                watcher.EnableRaisingEvents = true;

               WorkWithConsoleClass.ExitWatcherMode();
            }
        }

        private static void OnChanged(object source, FileSystemEventArgs e)
        {
            //FileEditingClass.CopyTheFileToBackups(e.Name);
            FileEditingClass.CopyAllFilesToBackups();
            Console.WriteLine($"File {e.FullPath} {e.ChangeType}");
        }

        private static void OnRenamed(object source, RenamedEventArgs e)
        {
            FileEditingClass fileEditingClass = new FileEditingClass();
            //FileEditingClass.CopyTheFileToBackups(e.Name);
            FileEditingClass.CopyAllFilesToBackups();
            fileEditingClass.SaveNewPathForRenamedFiles(e.OldFullPath, e.FullPath);
            Console.WriteLine($"File {e.OldFullPath} renamed to {e.FullPath}");
        }
    }
}