using System;

namespace LegacyApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("=== Legacy Console Application (v1.0, .NET Framework 4.7.2) ===");
            Console.WriteLine("This simulates a legacy monolithic app before modernization.\n");

            bool exit = false;
            while (!exit)
            {
                Console.WriteLine("\nChoose an option:");
                Console.WriteLine("1. Reverse a string");
                Console.WriteLine("2. Count words in a sentence");
                Console.WriteLine("3. Calculate factorial");
                Console.WriteLine("4. Check if number is prime");
                Console.WriteLine("5. Simulate file read/write");
                Console.WriteLine("0. Exit");

                Console.Write("\nEnter choice: ");
                string input = Console.ReadLine();

                switch (input)
                {
                    case "1":
                        Console.Write("Enter text: ");
                        string text = Console.ReadLine();
                        Console.WriteLine("Reversed: " + Utilities.ReverseString(text));
                        break;

                    case "2":
                        Console.Write("Enter a sentence: ");
                        string sentence = Console.ReadLine();
                        Console.WriteLine("Word count: " + Utilities.WordCount(sentence));
                        break;

                    case "3":
                        Console.Write("Enter a number: ");
                        if (int.TryParse(Console.ReadLine(), out int n))
                        {
                            Console.WriteLine($"Factorial({n}) = {Utilities.Factorial(n)}");
                        }
                        else
                        {
                            Console.WriteLine("Invalid number.");
                        }
                        break;

                    case "4":
                        Console.Write("Enter a number: ");
                        if (int.TryParse(Console.ReadLine(), out int num))
                        {
                            Console.WriteLine(num + (Utilities.IsPrime(num) ? " is prime." : " is not prime."));
                        }
                        else
                        {
                            Console.WriteLine("Invalid number.");
                        }
                        break;

                    case "5":
                        Console.Write("Enter file content to write: ");
                        string fileContent = Console.ReadLine();
                        string filePath = "legacy_output.txt";
                        Utilities.WriteToFile(filePath, fileContent);
                        Console.WriteLine("File written. Reading back...");
                        Console.WriteLine("File content: " + Utilities.ReadFromFile(filePath));
                        break;

                    case "0":
                        exit = true;
                        break;

                    default:
                        Console.WriteLine("Invalid choice, try again.");
                        break;
                }
            }

            Console.WriteLine("\nExiting Legacy App. Goodbye!");
        }
    }
}
