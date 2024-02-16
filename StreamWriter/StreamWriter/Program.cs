﻿using System.IO;

namespace StreamWriter_course;
    internal class Program
    {
        static void Main(string[] args)
        {
            string sourcePath = @"C:\temp\file1.txt";
            string TargetPath = @"C:\temp\file2.txt";
            try
            {
                string[] lines = File.ReadAllLines(sourcePath);
                using(StreamWriter sw = File.AppendText(TargetPath))
                foreach (string line in lines)
                {
                    sw.WriteLine(line.ToUpper());
                }
            }
            catch(IOException e)
            {
                Console.WriteLine("An issue occurred.");
                Console.WriteLine(e.Message);
            }
        }
    }