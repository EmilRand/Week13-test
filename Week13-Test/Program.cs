﻿using System;
using System.IO;

namespace Ylesanne1
{
    class Program
    {
        static void Main(string[] args)
        {
            string rootDirectory = @"C:\Users\opilane\Samples\Logitpe21";

            Console.WriteLine("Enter directory  name:");
            string userFolder = Console.ReadLine();

            string newDirectoryFullPath = $@"{rootDirectory}\{userFolder}";
            bool directoryExists = Directory.Exists(newDirectoryFullPath);

            if (directoryExists)
            {
                Console.WriteLine($"{userFolder} already exists.");
            }
            else
            {
                Directory.CreateDirectory(newDirectoryFullPath);
                Console.WriteLine($"Directory {userFolder} has been created.");
            }

            Directory.CreateDirectory(newDirectoryFullPath);

        }
    }
}