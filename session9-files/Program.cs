using System;

namespace MyApp // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Make sure to change this folder to your own folder  
                string folder = @"/Users/abtin_cheg/Desktop/CsharpMainClass/CsharpClass/session9-files/";  
                // Filename  
                string fileName = "test.txt";  
                // Fullpath. You can direct hardcode it if you like.  
                string fullPath = folder + fileName;  
                // An array of strings  
                string[] authors = {"Mahesh Chand", "Allen O'Neill", "David McCarter",  
                "Raj Kumar", "Dhananjay Kumar"};  
                // Write array of strings to a file using WriteAllLines.  
                // If the file does not exists, it will create a new file.  
                // This method automatically opens the file, writes to it, and closes file  
                File.WriteAllLines(fullPath, authors);  
                // Read a file  
                string readText = File.ReadAllText(fullPath);  
                Console.WriteLine(readText);  
        }
    }
}
