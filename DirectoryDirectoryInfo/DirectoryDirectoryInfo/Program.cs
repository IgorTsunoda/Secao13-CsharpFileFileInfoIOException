using System;
using System.IO;

namespace DirectoryDirectoryInfo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string path = @"c:\temp\myfolder";

            try
            {
                IEnumerable<string> folders = Directory.EnumerateDirectories(path, "*.*", SearchOption.AllDirectories);
                Console.WriteLine("FOLDERS: ");
                foreach (string element in folders)
                {
                    Console.WriteLine(element);
                }
                IEnumerable<string> files = Directory.EnumerateFiles(path, "*.*", SearchOption.AllDirectories);
                Console.WriteLine();
                Console.WriteLine("FILES");
                foreach (string element in files)
                {
                    Console.WriteLine(element);
                }

                Directory.CreateDirectory(path + @"\newfolder");

            }
            catch (IOException e) 
            {
                Console.WriteLine("An error occurred");
                Console.WriteLine(e.Message);
            }
        }
    }
}