using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Udemy
{
    public class Lecture43
    {
        public static void RunLecture43()
        {
            // Header section 
            StringBuilder header = new StringBuilder();
            header.AppendLine("----------------------").AppendLine("LECTURE 43 EXERCISES").AppendLine("----------------------");
            Console.Write(header);

            // Lecture 43: Problem 1 
            Console.WriteLine("Problem 1:\nEnter (float) value between 1 and 10");
            float.TryParse(Console.ReadLine(), out float value);

            if (value >= 1 && value <= 10)
            {
                Console.WriteLine($"You provided value: {value}. Valid.\n");
            }
            else
            {
                Console.WriteLine("You provided an invalid value. Moron. It's invalid.\n");
            }

            // Lecture 43: Problem 2 
            Console.WriteLine("Problem 2:\nEnter first number");
            float first = float.Parse(Console.ReadLine());

            Console.WriteLine("Enter second number");
            float second = float.Parse(Console.ReadLine());

            float maxNumber = first > second ? first : second;
            Console.WriteLine($"The maximum of the two numbers is {maxNumber}\n");


            // Lecture 43: Problem 3
            Console.WriteLine("Problem 3:\nEnter height");
            float height = float.Parse(Console.ReadLine());

            Console.WriteLine("Enter width");
            float width = float.Parse(Console.ReadLine());

            string pictureSize = height > width ? "portrait" : "landscape";
            Console.WriteLine($"The picture size is {pictureSize}\n");

            // Lecture 43: Problem 4
            Console.WriteLine("Problem 4:\nEnter speed limit");
            float limit = float.Parse(Console.ReadLine());

            Console.WriteLine("Enter current speed");
            float speed = float.Parse(Console.ReadLine());

            if (speed <= limit)
            {
                Console.WriteLine("OK\n");
            }
            else
            {
                int demerit = DetermineDemeritPoints(limit, speed);

                if (demerit > 12)
                {
                    Console.WriteLine($"Demerit points are: {demerit}. License suspended.\n");
                }
                else
                {
                    Console.WriteLine($"Demerit points are: {demerit}. Be careful - if points exceed 12, license may be suspended.\n");
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
