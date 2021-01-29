using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Security.Permissions;
using System.Threading;

namespace Stream_Serialization
{
    class Program
    {
        static void Main(string[] args)
        {
            string firstDir = @"C:\Users\mihai\Downloads\dir1";
            string secondDir = @"C:\Users\mihai\Downloads\dir2";

            var _ = new Watcher(firstDir, secondDir);
        }
    }
}









//static void Main(string[] args)
//{
//    using (FileSystemWatcher watcher = new FileSystemWatcher())
//    {
//        watcher.Path = InDirectory;
//        watcher.NotifyFilter = NotifyFilters.LastAccess
//                             | NotifyFilters.LastWrite
//                             | NotifyFilters.FileName
//                             | NotifyFilters.DirectoryName;

//        watcher.Changed += OnChanged;
//        watcher.Created += OnChanged;
//        watcher.Deleted += OnChanged;
//        // Begin watching.
//        watcher.EnableRaisingEvents = true;

//        var copyFiles = copyContentToTargetFolderTask.Result;
//        Console.WriteLine(copyFiles);
//        var deleteFiles = deleteContentFromTargetFolderTask.Result;
//        Console.WriteLine(deleteFiles);

//        Console.ReadKey();
//    }
//}
//// Define the event handlers.
//private static void OnChanged(object source, FileSystemEventArgs e)
//{
//    // Specify what is done when a file is changed, created, or deleted.
//    Console.WriteLine($"File: {e.FullPath} {e.ChangeType}");
//    var copyFiles = copyContentToTargetFolderTask.Result;
//    var deleteFiles = deleteContentFromTargetFolderTask.Result;
//    Console.WriteLine($"Some chnanges in folder {copyFiles}");
//    Console.WriteLine($"Some chnanges in folder {deleteFiles}");
//}

//static async Task<bool> CopyContentToTargetFolder()
//{
//    foreach (string fileName in Directory.EnumerateFiles(InDirectory))
//    {
//        using (FileStream SourceStream = File.Open(fileName, FileMode.Open))
//        {
//            using (FileStream DestinationStream = File.Create(OutDirectory + fileName.Substring(fileName.LastIndexOf('\\'))))
//            {
//                await SourceStream.CopyToAsync(DestinationStream);

//            }
//        }
//    }
//    return true;
//}
//static async Task<bool> DeleteContentFromTargetFolder()
//{
//    foreach (string fileNameOut in Directory.EnumerateFiles(OutDirectory))
//    {
//        if (Directory.EnumerateFiles(InDirectory).Contains(fileNameOut))
//        {
//            using (FileStream stream = new FileStream(fileNameOut, FileMode.Truncate, FileAccess.Write, FileShare.Delete, 4096, true))
//            {
//                await stream.FlushAsync();
//                File.Delete(fileNameOut);
//            }
//        }
//    }
//    return true;
//}