using System;
using System.Linq;
using System.Text;

namespace Udemy
{
    public class Lecture49
    {
        internal static void RunLecture49()
        {
            // Header section 
            StringBuilder header = new StringBuilder();
            header.AppendLine("----------------------").AppendLine("LECTURE 49 EXERCISES").AppendLine("----------------------");
            Console.Write(header);

            // Lecture 49: Problem 1 
            int startNum = 1;
            int endNum = 100;
            int count = 0;

            for (int i = startNum; i <= endNum; i++)
            {
                if (i % 3 == 0)
                {
                    count++;
                }
            }

            Console.WriteLine($"Problem 1:\nThere are {count} numbers between 1 and 100 that are divisible by 3.\n");

            // Lecture 49: Problem 2
            double total = 0;
            Console.WriteLine("Problem 2:\n");

            while (true)
            {
                Console.WriteLine("Enter a number to sum to total, or enter ok to quit.");
                string response = Console.ReadLine();
                if (response.Trim().ToLower() == "ok")
                {
                    Console.WriteLine($"The sum of the numbers you entered is: {total}");
                    break;
                }
                else
                {
                    total += double.Parse(response);
                }
            }

            // Lecture 49: Problem 3 
            double factorial = 1;
            Console.WriteLine("\nProblem 3:\nEnter a number for which to calculate the factorial.");
            double maxNumber = double.Parse(Console.ReadLine());

            for (int i = 1; i <= maxNumber; i++)
            {
                factorial = factorial * i;
            }

            Console.WriteLine($"The factorial of the number is {factorial}.");

            // Lecture 49: Problem 4
            Console.WriteLine("\nProblem 4:\nGuess what the random lottery number is! Hint: something between 1 and 10. You get upto 4 chances.");
            Random random = new Random();
            int randomNumber = random.Next(1, 10);
            int chances = 1;
            bool responseCorrect = false;

            Console.WriteLine("Make a guess:");

            do
            {
                responseCorrect = Int32.Parse(Console.ReadLine()) == randomNumber;
                chances++;

                if (responseCorrect == true)
                {
                    Console.WriteLine("Well done! You guessed the correct number!");
                    break;
                }

                Console.WriteLine("Wrong answer.");

            } while (chances <= 4);

            if (responseCorrect == false)
            {
                Console.WriteLine("Sorry - no prize. You used all your chances.");
            }

            // Lecture 49: Problem 5
            Console.WriteLine("\nProblem 5:\nEnter a series of numbers seperated by a comma, e.g \"5, 3, 8, 1, 4\".");
            string numbersList = Console.ReadLine();
            double maximum = numbersList.Split(',').Select(x => double.Parse(x)).ToList().Max();
            Console.WriteLine($"The largest number you entered is {maximum}.\n");

        }
    }
}
