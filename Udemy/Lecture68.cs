using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Udemy
{
    public class Lecture68
    {
        internal static void RunProblem1()
        {
            // Lecture 68: Problem 1 
            Console.Write("Problem 1:\nEnter some numbers seperated by a hyphen: ");
            Console.WriteLine(HelperFunctions.IsConsecutiveNumbers(HelperFunctions.ParseHyphenatedNumbersToList(Console.ReadLine())));
        }

        internal static void RunProblem2()
        {
            // Lecture 68: Problem 2
            Console.Write("\nProblem 2:\nEnter some numbers seperated by a hyphen: ");
            string numbersList = Console.ReadLine();

            if (!string.IsNullOrWhiteSpace(numbersList) && HelperFunctions.DuplicatesInList(HelperFunctions.ParseHyphenatedNumbersToList(numbersList)))
            {
                Console.WriteLine($"Duplicate.");
            }
        }

        internal static void RunProblem3()
        {
            // Lecture 68: Problem 3 
            Console.WriteLine("\nProblem 3:\nEnter a valid 24-hour time format; i.e. between 00:00 and 23:59.");
            Console.WriteLine(HelperFunctions.Validate24HourUserTime(Console.ReadLine()));
        }

        internal static void RunProblem4()
        {
            // Lecture 68: Problem 4
            Console.WriteLine("\nProblem 4:\nEnter some words seperated by a space to convert to Pascal case:");
            Console.WriteLine($"Pascal case: {HelperFunctions.ParseAsPascalCase(Console.ReadLine())}");
        }

        internal static void RunProblem5()
        {
            // Lecture 68: Problem 5
            Console.WriteLine("\nProblem 5:\nEnter a word:");
            Console.WriteLine($"There are  {HelperFunctions.CountVowelsInString(Console.ReadLine())} vowels in the word.\n");
        }

        internal static void RunLecture68()
        {
            // Header section 
            StringBuilder header = new StringBuilder();
            header.AppendLine("----------------------").AppendLine("LECTURE 68 EXERCISES").AppendLine("----------------------");
            Console.Write(header);

            RunProblem1();
            RunProblem2();
            RunProblem3();
            RunProblem4();
            RunProblem5();
        }
    }
}