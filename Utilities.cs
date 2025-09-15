using System;
using System.IO;

namespace LegacyApp
{
    public static class Utilities
    {
        public static string ReverseString(string input)
        {
            if (string.IsNullOrEmpty(input)) return "";
            char[] arr = input.ToCharArray();
            Array.Reverse(arr);
            return new string(arr);
        }

        public static int WordCount(string sentence)
        {
            if (string.IsNullOrWhiteSpace(sentence)) return 0;
            return sentence.Split(new char[] { ' ', '\t' }, StringSplitOptions.RemoveEmptyEntries).Length;
        }

        public static long Factorial(int n)
        {
            if (n < 0) throw new ArgumentException("Negative numbers not allowed");
            return (n == 0 || n == 1) ? 1 : n * Factorial(n - 1);
        }

        public static bool IsPrime(int n)
        {
            if (n <= 1) return false;
            if (n == 2) return true;
            if (n % 2 == 0) return false;

            for (int i = 3; i <= Math.Sqrt(n); i += 2)
            {
                if (n % i == 0) return false;
            }
            return true;
        }

        public static void WriteToFile(string filePath, string content)
        {
            File.WriteAllText(filePath, content);
        }

        public static string ReadFromFile(string filePath)
        {
            return File.Exists(filePath) ? File.ReadAllText(filePath) : "File not found.";
        }
    }
}
