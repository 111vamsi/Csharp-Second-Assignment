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
                File.Delete(filePath);
                Console.WriteLine("Existing file deleted.");
            }

            using (FileStream fs = File.Create(filePath))
            {
            }

            Console.WriteLine("A new blank file has been created successfully.");
        }
        catch (Exception ex)
        {
            Console.WriteLine("An error occurred: " + ex.Message);
        }
        Console.ReadKey();
    }
}
