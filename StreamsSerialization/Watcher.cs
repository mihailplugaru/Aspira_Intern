using System;
using System.IO;

namespace SerialisationStream
{
    public class Watcher
    {
        public static string SecondDir { get; set; } 

        public Watcher(string path, string secondDir)
        {
            SecondDir = secondDir;
            
            CheckForUpdates(path, SecondDir); 

            Watch(path, SecondDir);
        }
        private static void Watch(string path, string secondDir)
        {
            using (FileSystemWatcher watcher = new FileSystemWatcher())
            {
                watcher.Path = path;

                watcher.NotifyFilter = NotifyFilters.LastWrite
                                     | NotifyFilters.FileName
                                     | NotifyFilters.DirectoryName;

                watcher.IncludeSubdirectories = true;
                watcher.Filter = "*.*"; 

                // event handlers
                watcher.Changed += OnChanged;
                watcher.Created += OnChanged;
                watcher.Deleted += OnChanged;
                watcher.Renamed += OnRenamed;

                watcher.EnableRaisingEvents = true;

                Console.WriteLine("Enter 'q' to quite the program.\n");
                while (Console.Read() != 'q') ;
            }
        }

        
        private static void OnChanged(object sender, FileSystemEventArgs e)
        {
            Console.WriteLine($"File: {e.FullPath} {e.ChangeType}");

            var path = Path.Combine(SecondDir + "\\" + e.Name);
            var extension = Path.GetExtension(e.FullPath);

            if (extension == ".txt")
            {
                if (e.ChangeType.ToString() == "Deleted")
                {
                    try
                    {
                        File.Delete(path);
                    }
                    catch (FileNotFoundException ex)
                    {
                        Console.WriteLine(ex.Message);
                    }
                }
                else
                {
                    SyncFile(e.FullPath, path);
                }
            }
            else
            {
                if (e.ChangeType.ToString() == "Deleted")
                {
                    try
                    {
                        Directory.Delete(path, true);
                    }
                    catch (DirectoryNotFoundException ex)
                    {
                        Console.WriteLine(ex.Message);
                    } 
                }
                else
                {
                    if (e.ChangeType.ToString() == "Created")
                    {
                        Directory.CreateDirectory(path);
                    }

                    SyncDir(e.FullPath, path);
                }
            }
        }

        private static void OnRenamed(object sender, RenamedEventArgs e)
        {
            Console.WriteLine($"File: {e.OldFullPath} renamed to {e.FullPath}");

            var newPath = Path.Combine(SecondDir + "\\" + e.Name);
            var oldPath = Path.Combine(SecondDir + @"\" + e.OldName);
            var extension = Path.GetExtension(e.FullPath);

            if (extension == ".txt")
            {
                try
                {
                    if (!File.Exists(newPath))
                    {
                        File.Move(oldPath, newPath);
                    }
                }
                catch (FileNotFoundException ex)
                {
                    Console.WriteLine(ex.Message);
                }
            }
            else
            {
                try
                {
                    Directory.Move(oldPath, newPath);
                }
                catch (DirectoryNotFoundException ex)
                {
                    Console.WriteLine(ex.Message);
                }
            }
        }

        public static async void SyncFile(string filename, string secondDir)
        {
            using (FileStream SourceStream = File.Open(filename, FileMode.Open))
            {
                using (FileStream DestinationStream = File.Create(secondDir))
                {
                    await SourceStream.CopyToAsync(DestinationStream);
                }
            }
        }

        public static async void SyncDir(string firstDir, string secondDir)
        {
           foreach (string filename in Directory.EnumerateFiles(firstDir))
           {
                using (FileStream SourceStream = File.Open(filename, FileMode.Open))
                {
                    using (FileStream DestinationStream = File.Create(secondDir + filename.Substring(filename.LastIndexOf('\\'))))
                    {
                        await SourceStream.CopyToAsync(DestinationStream);
                    }
                }
           }
        }

        public static void CheckForUpdates(string firstDir, string secondDir)
        {
            foreach (string filename in Directory.EnumerateFiles(firstDir))
            {
                var file1 = new FileInfo(filename);
                var file2 = new FileInfo(Path.Combine(secondDir + "\\" + file1.Name));

                if (file1.LastWriteTime > file2.LastWriteTime)
                {
                    SyncFile(file1.FullName, file2.FullName);
                }
                else
                {
                    SyncFile(file2.FullName, file1.FullName);
                }
            }

            foreach (string dirname in Directory.EnumerateDirectories(firstDir))
            {
                var path = Path.Combine(secondDir + "\\" + new DirectoryInfo(dirname).Name);

                if (!Directory.Exists(path))
                {
                    Directory.CreateDirectory(path);
                }

                foreach (string filename in Directory.EnumerateFiles(dirname))
                {
                    var file1 = new FileInfo(filename);
                    var file2 = new FileInfo(Path.Combine(path + "\\" + file1.Name));

                    if (file1.LastWriteTime > file2.LastWriteTime)
                    {
                        SyncFile(file1.FullName, file2.FullName);
                    }
                    else
                    {
                        SyncFile(file2.FullName, file1.FullName);
                    }
                }
            }
        }
    }
}
