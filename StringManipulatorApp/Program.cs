using System;
using BasicStringManipulations;
using AdvancedStringManipulations;

namespace StringManipulatorApp
{
    class Program
    {
        static void Main(string[] args)
        {
            var basicManipulator = new BasicStringManipulations.StringManipulator();
            var advancedManipulator = new AdvancedStringManipulations.StringManipulator();

            Console.WriteLine("Enter a string:");
            string input = Console.ReadLine();

            string reversed = basicManipulator.Reverse(input);
            int vowelCount = advancedManipulator.CountVowels(input);

            Console.WriteLine($"Reversed String: {reversed}");
            Console.WriteLine($"Vowel Count: {vowelCount}");
        }
    }
}
