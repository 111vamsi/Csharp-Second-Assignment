using System;
using System.IO;

class Program
{
    static void Main()
    {
        string filePath = @"D:\\MyFile.txt";

        try
        {
            if (File.Exists(filePath))
            {
                string[] lines = File.ReadAllLines(filePath);

                int lineCount = lines.Length;

                Console.WriteLine("The number of lines in the file is: " + lineCount);
            }
            else
            {
                Console.WriteLine("The file does not exist.");
            }
        }
        catch (Exception ex)
        {
            Console.WriteLine("An error occurred: " + ex.Message);
        }
        Console.ReadLine();
    }
}
