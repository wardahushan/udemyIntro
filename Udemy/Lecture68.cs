﻿using System;
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
            string numbersList = Console.ReadLine();
            List<int> numbersDouble = numbersList.Split('-').Select(x => Int32.Parse(x)).ToList();
            numbersDouble.Sort();

            for (int i = 1; i < numbersDouble.Count; i++)
            {
                if (Math.Abs(numbersDouble[i] - numbersDouble[i-1]) != 1)
                {
                    Console.WriteLine("Not consecutive.");
                    return;
                }
            }

            Console.WriteLine("Consecutive.");
        }

        internal static void RunProblem2()
        {
            // Lecture 68: Problem 2
            Console.Write("\nProblem 2:\nEnter some numbers seperated by a hyphen: ");
            string numbersList = Console.ReadLine();

            if (!string.IsNullOrWhiteSpace(numbersList))
            {
                List<int> numbersDouble = numbersList.Split('-').Select(x => Int32.Parse(x)).ToList();
                if (numbersDouble.Distinct().Count() != numbersDouble.Count())
                {
                    Console.WriteLine($"Duplicate.");
                }
            }
        }

        internal static void RunProblem3()
        {
            // Lecture 68: Problem 3 
            Console.WriteLine("\nProblem 3:\nEnter a valid 24-hour time format; i.e. between 00:00 and 23:59.");
            string userTime = Console.ReadLine();
            string returnString = string.Empty;

            if (string.IsNullOrWhiteSpace(userTime))
            {
               returnString = "Invalid.";
            }
            else
            {
                List<int> userTimeToValidate = userTime.Split(':').Select(x => Int32.Parse(x)).ToList();
                returnString = userTimeToValidate.First() >= 0 && userTimeToValidate.First() <= 23 && userTimeToValidate.Last() >= 0 && userTimeToValidate.Last() <= 59 ? "Ok" : "Invalid";
            }

            Console.WriteLine(returnString);
        }
        
        internal static void RunProblem4()
        {
            // Lecture 68: Problem 4
            Console.WriteLine("\nProblem 4:\nEnter some words seperated by a space:");
            string[] wordsArray = Console.ReadLine().Split(' ').ToArray();
            string pascalCase = string.Empty;

            foreach (string word in wordsArray)
            {
                pascalCase += word.Substring(0, 1).ToUpper() + word.Substring(1).ToLower();
            }

            Console.WriteLine($"Pascal case: {pascalCase}");
        }

        internal static void RunProblem5()
        {
            // Lecture 68: Problem 5
            Console.WriteLine("\nProblem 5:\nEnter a word:");
            string word = Console.ReadLine();

            Console.WriteLine($"There are " +
                $"{word.ToLower().ToCharArray().Where(x => x.ToString() == "a" || x.ToString() == "e" || x.ToString() == "i" || x.ToString() == "o" || x.ToString() == "u").Count()} " +
                $"vowels in the word.\n");
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