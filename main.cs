using System;
using System.IO;

class Program
{
    static void Main()
    {
        string filePath = "AI_Names.txt";

        // Check if the file does not exist and create it
        if (!File.Exists(filePath))
        {
            Console.WriteLine("File does not exist. Creating now...");
            File.Create(filePath).Close(); // Creates and immediately closes the file
        }

        // Array of AI model names
        string[] aiNames = { "ChatGPT-3", "ChatGPT-3.5", "ChatGPT-4", "ChatGPT-4 Turbo", "ChatGPT-X" };

        // Write AI names to the file
        File.WriteAllLines(filePath, aiNames);
        Console.WriteLine("AI names saved to file.");

        // Read and display AI names from the file
        string[] readNames = File.ReadAllLines(filePath);
        Console.WriteLine("AI names from file:");
        foreach (string name in readNames)
        {
            Console.WriteLine(name);
        }
    }
}
