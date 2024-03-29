﻿using System.IO;

namespace FileStram_StreamReader
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string path = @"C:\temp\file1.txt";
            FileStream fs = null;
            StreamReader sr = null;
            try
            {
                sr = File.OpenText(path);
                while (!sr.EndOfStream)
                {
                    string line = sr.ReadLine();
                    Console.WriteLine(line);
                }
            }
            catch (Exception e)
            {
                Console.WriteLine("An issue occurred.");
                Console.WriteLine(e.Message);
            }
            finally
            {
                if (sr != null) sr.Close();
                if (fs != null) fs.Close();
            }
        }
    }
}