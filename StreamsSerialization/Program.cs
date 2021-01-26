using System;

namespace SerialisationStream
{
    class Program
    {
    
        static void Main(string[] args)
        {
            string firstDir = @"C:\Users\Vladimir\Desktop\first";
            string secondDir = @"C:\Users\Vladimir\Desktop\second";

            var watcher = new Watcher(firstDir, secondDir);
        }
    }
}
