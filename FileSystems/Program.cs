using System;
using System.IO;

namespace FileSystems
{
    class Program
    {
        static void Main(string[] args)
        {
            string rootdirectory = @"C:\Users\opilane\samples";
            Console.WriteLine("enter directory name:");
            string userfolder = Console.ReadLine();
            string newDirectoryFullPath = @$"{rootdirectory}\{userfolder}";
            bool directoryExists = Directory.Exists(newDirectoryFullPath);
            if (directoryExists)
            {
                Console.WriteLine($"{userfolder}exists");
                Console.WriteLine("Do you like to create a folder? Y/N");
                char userInput = Convert.ToChar(Console.ReadLine().ToLower());
                if(userInput == 'y')
                {
                    Console.WriteLine("Enter file name");
                    string userFile = Console.ReadLine() + ".txt";
                    string userFileFullPath = $@"{newDirectoryFullPath}\{userFile}";
                    File.Create(userFileFullPath);
                }
                else
                {
                    Console.WriteLine("Take cate!");
                }
            }
            else
            {
                Directory.CreateDirectory(newDirectoryFullPath);
                Console.WriteLine($"Directory{userfolder} has been created.");
            }
            
        }
    }
}
