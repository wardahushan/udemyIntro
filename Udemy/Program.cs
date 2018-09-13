using System;

namespace Udemy
{
    class Program
    {
        static void Main(string[] args)
        {
            // Lecture 43: Problem 1 
            Console.WriteLine("Enter (float) value between 1 and 10");
            float.TryParse(Console.ReadLine(), out float value);

            if (value >= 1 && value <= 10)
            {
                Console.WriteLine($"You provided value: {value}. Valid.");
            }
            else
            {
                Console.WriteLine("You provided an invalid value. Moron. It's invalid.");
            }

            // Lecture 43: Problem 2 
            Console.WriteLine("Enter first number");
            float first = float.Parse(Console.ReadLine());

            Console.WriteLine("Enter second number");
            float second = float.Parse(Console.ReadLine());

            float maxNumber = first > second ? first : second;
            Console.WriteLine($"The maximum of the two numbers is {maxNumber}");


            // Lecture 43: Problem 3
            Console.WriteLine("Enter height");
            float height = float.Parse(Console.ReadLine());

            Console.WriteLine("Enter width");
            float width = float.Parse(Console.ReadLine());

            string pictureSize = height > width ? "portrait" : "landscape";
            Console.WriteLine($"The picture size is {pictureSize}");

            // Lecture 43: Problem 4
            Console.WriteLine("Enter speed limit");
            float limit = float.Parse(Console.ReadLine());

            Console.WriteLine("Enter current speed");
            float speed = float.Parse(Console.ReadLine());

            if (speed <= limit)
            {
                Console.WriteLine("OK");
            }
            else
            {
                int demerit = DetermineDemeritPoints(limit, speed);

                if (demerit > 12)
                {
                    Console.WriteLine($"Demerit points are: {demerit}. License suspended.");
                }
                else
                {
                    Console.WriteLine($"Demerit points are: {demerit}. Be careful - if points exceed 12, license may be suspended.");
                }
            }
        }

        public static int DetermineDemeritPoints(float limit, float speed)
        {
            int demeritPoints = (int)(speed - limit) / 5;
            return demeritPoints;
        }
    }
}
