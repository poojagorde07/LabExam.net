using System;
using System.IO;
namespace Lab1
{

    class Program
    {
        static void Main()
        {
            string filePath = "mytest.txt";
            string fileContent = "Hello and Welcome\n\nIt is the first content\n\nof the text file mytest.txt";

            // Create the text file and write content to it
            File.WriteAllText(filePath, fileContent);

            // Read the content of the text file
            string fileContentRead = File.ReadAllText(filePath);

            // Display the content of the text file
            Console.WriteLine("Here is the content of the file mytest.txt:\n");
            Console.WriteLine(fileContentRead);
        }
    }
}