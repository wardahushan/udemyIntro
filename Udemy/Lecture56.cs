using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Udemy
{
    public class Lecture56
    {
        internal static void Problem1()
        {
            // Header section 
            StringBuilder header = new StringBuilder();
            header.AppendLine("----------------------").AppendLine("LECTURE 56 EXERCISES").AppendLine("----------------------");
            Console.Write(header);

            // Lecture 56: Problem 1 
            Console.WriteLine($"Problem 1:\n");
            List<string> names = new List<string>();

            while (true)
            {
                Console.WriteLine("Enter the name of a friend. If you have no more, just press ENTER:");
                string name = Console.ReadLine();

                if (string.IsNullOrEmpty(name))
                {
                    break;
                }
                else
                {
                    names.Add(name);
                }
            }

            switch (names.Count)
            {
                case 0:
                    Console.WriteLine($"You have no friends.\n");
                    break;
                case 1:
                    Console.WriteLine($"You have one friend - {names.First()}.\n");
                    break;
                case 2:
                    Console.WriteLine($"You have two friends - {names.First()} and {names.Last()}.\n");
                    break;
                default:
                    Console.WriteLine($"You have {names.Count} friends! - {names.First()}, {names.Skip(1).First()} and {names.Count - 2} others!\n");
                    break;
            }
        }

        internal static void Problem2()
        {
            // Lecture 56: Problem 2
            Console.Write("Problem 2:\nEnter your name: ");
            string name = Console.ReadLine();
            char[] nameArray = name.ToCharArray();
            string nameReversed = string.Empty;

            foreach (char letter in nameArray)
            {
                nameReversed = letter.ToString() + nameReversed;
            }

            Console.WriteLine($"Your name reversed is: {nameReversed}.");
        }

        internal static void Problem3()
        {

            // Lecture 56: Problem 3 
            Console.WriteLine("\nProblem 3:\nEnter 5 distinct numbers seperated by a comma, e.g \"5, 3, 8, 1, 4\".");
            string numbersList = Console.ReadLine();
            List<double> numbersDouble = numbersList.Split(',').Select(x => double.Parse(x)).ToList();

            if (numbersDouble.Count() != numbersDouble.Distinct().Count())
            {
                throw new NotSupportedException("Failed. You were supposed to enter 5 unqiue numbers!");
            }

            Console.WriteLine("\nNumbers sorted: ");

            numbersDouble.Sort();

            foreach (double number in numbersDouble)
            {
                Console.Write(number + " ");
            }
        }

        internal static void Problem4()
        {
            // Lecture 56: Problem 4
            Console.WriteLine("\nProblem 4:\nKeep typing in numbers to add them to a list. Type Quit to return.\n");
            List<double> numbers = new List<double>();

            while (true)
            {
                string response = Console.ReadLine();
                if (response.ToLower() == "quit")
                {
                    Console.Write("Unique numbers you entered: ");
                    foreach (double number in numbers.Distinct())
                    {
                        Console.Write(number + " ");
                    }
                    Console.Write("\n");
                    return;
                }
                else
                {
                    numbers.Add(double.Parse(response));
                }
            }
        }

        internal static void Problem5()
        {
            // Lecture 56: Problem 5
            Console.WriteLine("\nProblem 5:\nEnter at least 5 numbers seperated by a comma, e.g \"5, 3, 8, 1, 4\".");
            string numbersList = Console.ReadLine();

            if (!string.IsNullOrWhiteSpace(numbersList) && numbersList.Split(',').Select(x => double.Parse(x)).ToList().Count() < 5)
            {
                throw new NotSupportedException("Failed: invalid list. Enter at least 5 numbers!");
            }
            else
            {
                List<double> numbersDouble = numbersList.Split(',').Select(x => double.Parse(x)).ToList();
                Console.WriteLine("\nFirst 3 numbers sorted: ");

                numbersDouble.Sort();

                foreach (double number in numbersDouble.Take(3))
                {
                    Console.Write(number + " ");
                }
            }
        }
    }
}