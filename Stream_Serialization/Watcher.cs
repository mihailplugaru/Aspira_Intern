using System;
using System.IO;

namespace Stream_Serialization
{
    public class Watcher
    {
        public static string SecondDir { get; set; }

        public Watcher(string firstDir, string secondDir)
        {
            SecondDir = secondDir;

            CheckForUpdates(firstDir, SecondDir);

            Watch(firstDir);
        }

        private static void Watch(string firstDir)
        {
            using (FileSystemWatcher watcher = new FileSystemWatcher())
            {
                watcher.Path = firstDir;

                watcher.NotifyFilter = NotifyFilters.LastWrite
                                     | NotifyFilters.FileName
                                     | NotifyFilters.DirectoryName;

                watcher.IncludeSubdirectories = true;
                watcher.Filter = "*.*";

                // Event handlers
                watcher.Changed += OnChanged;
                watcher.Created += OnChanged;
                watcher.Deleted += OnChanged;
                watcher.Renamed += OnRenamed;
                // Begin watching
                watcher.EnableRaisingEvents = true;

                Console.ReadKey();
            }
        }

        private static void OnChanged(object sender, FileSystemEventArgs e)
        {
            Console.WriteLine($"File: {e.FullPath} {e.ChangeType}");

            var pathd2 = Path.Combine(SecondDir + "\\" + e.Name);
            var extension = Path.GetExtension(e.FullPath);

            if (IsTextFile(extension))
            {
                if (e.ChangeType.ToString() == "Deleted")
                {
                    try
                    {
                        File.Delete(pathd2);
                    }
                    catch (FileNotFoundException ex)
                    {
                        Console.WriteLine(ex.Message);
                    }
                }
                else
                {
                    SyncFile(e.FullPath, pathd2);
                }
            }
            else
            {
                if (e.ChangeType.ToString() == "Deleted")
                {
                    try
                    {
                        Directory.Delete(pathd2, true);
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
                        Directory.CreateDirectory(pathd2);
                    }

                    SyncDir(e.FullPath, pathd2);
                }
            }
        }

        private static void OnRenamed(object sender, RenamedEventArgs e)
        {
            Console.WriteLine($"File: {e.OldFullPath} renamed to {e.FullPath}");

            var newPath = Path.Combine(SecondDir + "\\" + e.Name);
            var oldPath = Path.Combine(SecondDir + @"\" + e.OldName);
            var extension = Path.GetExtension(e.FullPath);

            if (IsTextFile(extension))
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

        public static void CheckForUpdates(string firstDir, string secondDir)
        {
            foreach (string filename in Directory.EnumerateFiles(secondDir))
            {
                File.Delete(filename);
            }

            foreach (string filename in Directory.EnumerateFiles(firstDir))
            {
                var file1 = new FileInfo(filename);
                var file2 = new FileInfo(Path.Combine(secondDir + "\\" + file1.Name));

                SyncFile(file1.FullName, file2.FullName);
            }

            foreach (string dirname in Directory.EnumerateDirectories(secondDir))
            {
                Directory.Delete(dirname);
            }

            foreach (string dirname in Directory.EnumerateDirectories(firstDir))
            {
                var path = Path.Combine(secondDir + "\\" + new DirectoryInfo(dirname).Name);

                Directory.CreateDirectory(path);

                foreach (string filename in Directory.EnumerateFiles(dirname))
                {
                    var file1 = new FileInfo(filename);
                    var file2 = new FileInfo(Path.Combine(path + "\\" + file1.Name));

                    SyncFile(file1.FullName, file2.FullName);
                }
            }
        }

        public static async void SyncFile(string filename, string secondDir)
        {
            var fname = filename;
            var secdir = secondDir;
            try
            {
                using (FileStream SourceStream = File.Open(filename, FileMode.Open))
                {
                    using (FileStream DestinationStream = File.Create(secondDir))
                    {
                        await SourceStream.CopyToAsync(DestinationStream);
                    }
                }
            }
            catch
            {
                SyncFile(fname, secdir);
            }
        }

        public static async void SyncDir(string firstDir, string secondDir)
        {
            var dname = firstDir;
            var secdir = secondDir;
            try
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
            catch
            {
                SyncDir(dname, secdir);
            }
        }

        public static bool IsTextFile(string extension)
        {
            return extension == ".txt" || extension == ".rtf";
        }
    }
}





//public static void CheckForUpdates(string firstDir, string secondDir)
//{
//    foreach (string filename in Directory.EnumerateFiles(firstDir))
//    {
//        var file1 = new FileInfo(filename);
//        var file2 = new FileInfo(Path.Combine(secondDir + "\\" + file1.Name));

//        if (file1.LastWriteTime > file2.LastWriteTime)
//        {
//            SyncFile(file1.FullName, file2.FullName);
//        }
//        else
//        {
//            SyncFile(file2.FullName, file1.FullName);
//        }
//    }

//    foreach (string dirname in Directory.EnumerateDirectories(firstDir))
//    {
//        var path = Path.Combine(secondDir + "\\" + new DirectoryInfo(dirname).Name);

//        if (!Directory.Exists(path))
//        {
//            Directory.CreateDirectory(path);
//        }

//        foreach (string filename in Directory.EnumerateFiles(dirname))
//        {
//            var file1 = new FileInfo(filename);
//            var file2 = new FileInfo(Path.Combine(path + "\\" + file1.Name));

//            if (file1.LastWriteTime > file2.LastWriteTime)
//            {
//                SyncFile(file1.FullName, file2.FullName);
//            }
//            else
//            {
//                SyncFile(file2.FullName, file1.FullName);
//            }
//        }
//    }
//}