using System;
using System.IO;

namespace TextToFile
{
    class TextToFile
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter your to-do list:");

            string input = Console.ReadLine();

            // Folder must already exist on machine. Program will only create the text file
            File.WriteAllText(@"C:\Users\Public\TestFolder\Text.txt", input);
        }
    }
}
