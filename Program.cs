using System;
using System.Collections.Generic;
using System.IO;

namespace FileSorter
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Press E to exit. ");


            while (CalculateAnswer()) ;


        }

        static bool CalculateAnswer()
        {
            Console.WriteLine("Please input a valid file path: \n");

            string filepath = Console.ReadLine();

            if (filepath.ToLower().Trim() == "e")
            {
                return false;
            }

            while (!File.Exists(filepath))
            {
                Console.WriteLine("Please input a valid file path.");
                filepath = Console.ReadLine();
            }

            FileInfo file = new FileInfo(filepath);

            Console.Write($"\nCreated at: {file.CreationTimeUtc} UTC\n");
            Console.Write($"Last modified at: {file.LastWriteTimeUtc} UTC\n");
            Console.Write($"File size: {file.Length} bytes\n");
            Console.Write($"File extension: {file.Extension}\n");

            return true;
        }
    }
}
